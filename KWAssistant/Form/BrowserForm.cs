using CefSharp;
using CefSharp.WinForms;
using KWAssistant.Handler;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class BrowserForm : System.Windows.Forms.Form
    {
        private readonly ChromiumWebBrowser _webBrowser;

        private bool _isLoadEnd = false;  //首次加载完毕

        private bool _hasError = false; //网页加载是否出错

        private string _errorText;  //出错信息

        public BrowserForm(string url = "about:blank", bool isPopup = false, bool visible = false)
        {
            InitializeComponent();

            //Enabled = false;    //用户不能操作浏览器
            Visible = visible;
            //不可视时不抢占主窗口的焦点
            WindowState = visible ? FormWindowState.Normal : FormWindowState.Minimized;

            _webBrowser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
                BrowserSettings = { DefaultEncoding = "UTF-8" },
                LifeSpanHandler = new LifeSpanHandler()
            };
            _webBrowser.FrameLoadEnd += _webBrowser_FrameLoadEnd;
            _webBrowser.LoadError += _webBrowser_LoadError;

            Controls.Add(_webBrowser);
            if (!isPopup && !visible)
            {
                //激活浏览器
                Show();
                Hide();
            }
            SuspendLayout();
            Size = new System.Drawing.Size(800, 600);
            FormBorderStyle = FormBorderStyle.Sizable;
            ResumeLayout();
        }

        private async void BrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _webBrowser.FrameLoadEnd -= _webBrowser_FrameLoadEnd;
            _webBrowser.LoadError -= _webBrowser_LoadError;
            foreach (var popup in OwnedForms)
            {
                popup.Dispose();
                popup.Close();
            }
            await Cef.GetGlobalCookieManager().DeleteCookiesAsync();
            _webBrowser.Dispose();
        }

        private void _webBrowser_LoadError(object sender, LoadErrorEventArgs e)
        {
            _errorText = e.ErrorText;
            _hasError = true;
        }

        private void _webBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain) _isLoadEnd = true;
        }

        /// <summary>
        /// 获取当前页面的Html源码
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetSourceAsync()
        {
            return await _webBrowser.GetBrowser().MainFrame.GetSourceAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// 使用浏览器打开链接
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cts"></param>
        /// <returns></returns>
        public async Task NavigateToAsync(string url, CancellationToken cts)
        {
            _webBrowser.Load(url);
            await Task.Run(async () =>
            {
                while (!_isLoadEnd)
                {
                    if (!_hasError) continue;
                    _hasError = false;
                    throw new Exception(_errorText);
                }
            }, cts).ConfigureAwait(false);
        }

        /// <summary>
        /// 异步执行JS代码
        /// </summary>
        /// <param name="code"></param>
        /// <param name="cts"></param>
        /// <param name="millisecondDelay">需要等待资源加载，延迟执行时间</param>
        /// <returns>执行结果</returns>
        public async Task<JavascriptResponse> ExecuteJsAsync(string code, CancellationToken cts, int millisecondDelay = 0)
        {
            if (millisecondDelay != 0) await Task.Delay(millisecondDelay, cts).ConfigureAwait(false);
            var res = await _webBrowser.GetBrowser().MainFrame.EvaluateScriptAsync(code).ConfigureAwait(false);
            return res;
        }

        /// <summary>
        /// 从百度搜索结果的第一页跳到指定页
        /// </summary>
        /// <param name="target">目标页</param>
        /// <param name="cts"></param>
        /// <param name="millisecondDelay"></param>
        /// <returns></returns>
        public async Task PageTurnTo(int target, CancellationToken cts, int millisecondDelay = 0)
        {
            var code = @"var myPages = document.querySelectorAll('#page a');";
            var jump = 0;
            if (target != 1)
            {
                if (target <= 10)
                {
                    code += $@"myPages[{target - 2}].click();";
                    await ExecuteJsAsync(code, cts, millisecondDelay).ConfigureAwait(false);
                }
                else
                {
                    jump = (int)Math.Ceiling((target - 10) / (double)4);
                }
            }
            if (jump != 0)
            {
                var temp = @"myPages[myPages.length - 2].click();";
                for (var i = 0; i < jump; ++i)
                {
                    await ExecuteJsAsync(code + temp, cts, millisecondDelay).ConfigureAwait(false);
                }
                var add = target - jump * 4 - 6;
                if (add != 0)
                {
                    temp = $@"myPages[{5 + add}].click();";
                    await ExecuteJsAsync(code + temp, cts, millisecondDelay).ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// 切换所有浏览器窗体的可视性，
        /// 并且在不可视的情况下最小化窗体，可视时恢复正常
        /// </summary>
        public void ToggleVisible()
        {
            Visible = !Visible;
            WindowState = Visible ? FormWindowState.Normal : FormWindowState.Minimized;
            foreach (var popup in OwnedForms)
            {
                popup.Visible = Visible;
                popup.WindowState = Visible ? FormWindowState.Normal : FormWindowState.Minimized;
            }
        }
    }
}
