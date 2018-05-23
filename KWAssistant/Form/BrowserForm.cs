using CefSharp;
using CefSharp.WinForms;
using KWAssistant.Util;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class BrowserForm : System.Windows.Forms.Form
    {
        private readonly ChromiumWebBrowser _webBrowser;

        private bool _hasError = false; //网页加载是否出错

        private string _errorText;  //出错信息

        public BrowserForm(string url = "about:blank", bool isPopup = false, bool visible = false)
        {
            InitializeComponent();

            //Enabled = false;    //用户不能操作浏览器
            _webBrowser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
                BrowserSettings = { DefaultEncoding = "UTF-8" },
                LifeSpanHandler = new LifeSpanHandler()
            };
            _webBrowser.LoadError += (sender, e) =>
            {
                _errorText = e.ErrorText;
                _hasError = true;
            };

            Controls.Add(_webBrowser);
            Visible = visible;
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

        /// <summary>
        /// 获取当前页面的Html源码
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetSourceAsync()
        {
            return await _webBrowser.GetBrowser().MainFrame.GetSourceAsync();
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
                await Task.Delay(500, cts);
                while (_webBrowser.GetBrowser().IsLoading)
                {
                    if (!_hasError) continue;
                    _hasError = false;
                    throw new Exception(_errorText);
                }
            }, cts);
        }

        /// <summary>
        /// 异步执行JS代码
        /// </summary>
        /// <param name="code"></param>
        /// <param name="cts"></param>
        /// <returns></returns>
        public async Task<JavascriptResponse> ExecuteJsAsync(string code, CancellationToken cts)
        {
            var res = await _webBrowser.GetBrowser().MainFrame.EvaluateScriptAsync(code);
            return await Task.Run(async () =>
            {
                await Task.Delay(500, cts);
                while (_webBrowser.GetBrowser().IsLoading)
                {
                    if (!_hasError) continue;
                    _hasError = false;
                    throw new Exception(_errorText);
                }
                return res;
            }, cts);
        }

        /// <summary>
        /// 从百度搜索结果的第一页跳到指定页
        /// </summary>
        /// <param name="target">目标页</param>
        /// <param name="cts"></param>
        /// <returns></returns>
        public async Task PageTurn(int target, CancellationToken cts)
        {
            var code = @"var myPages = document.querySelectorAll('#page a');";
            var jump = 0;
            if (target != 1)
            {
                if (target <= 10)
                {
                    code += $@"myPages[{target - 2}].click();";
                    await ExecuteJsAsync(code, cts);
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
                    await ExecuteJsAsync(code, cts);
                    await ExecuteJsAsync(temp, cts);
                }
                var add = target - jump * 4 - 6;
                if (add != 0)
                {
                    temp = $@"myPages[{5 + add}].click();";
                    await ExecuteJsAsync(code, cts);
                    await ExecuteJsAsync(temp, cts);
                }
            }
        }

        /// <summary>
        /// 百度搜索结果下一页
        /// </summary>
        /// <param name="cts"></param>
        /// <returns></returns>
        public async Task NextPage(CancellationToken cts)
        {
            var code = @"var myPages = document.querySelectorAll('#page a');" +
                       @"myPages[myPages.length - 1].click();";
            await ExecuteJsAsync(code, cts);
        }

        /// <summary>
        /// 保持所有子窗体与主窗体的可见性一致
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowserForm_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var popup in OwnedForms)
            {
                popup.Visible = Visible;
            }
        }
    }
}
