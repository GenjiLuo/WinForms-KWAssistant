using KWAssistant.Form;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using KWAssistant.Properties;

namespace KWAssistant
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //高DPI支持
            if (Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }

            try
            {
                //设置应用程序处理异常方式：ThreadException处理
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                //处理UI线程异常
                Application.ThreadException += (sender, e) =>
                {
                    var str = GetExceptionMsg(e.Exception, e.ToString());
                    MessageBox.Show(str, Resources.Tip, MessageBoxButtons.OK, MessageBoxIcon.Error);
                };

                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
                {
                    var str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
                    MessageBox.Show(str, Resources.Tip, MessageBoxButtons.OK, MessageBoxIcon.Error);
                };

                #region 应用程序的主入口点
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                #endregion
            }
            catch (Exception ex)
            {
                var str = GetExceptionMsg(ex, string.Empty);
                MessageBox.Show(str, Resources.Tip, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        private static string GetExceptionMsg(Exception ex, string backStr)
        {
            var builder = new StringBuilder();
            builder.AppendLine("****************************异常文本****************************");
            builder.AppendLine($"【出现时间】：{DateTime.Now.ToString(CultureInfo.InvariantCulture)}");
            if (ex != null)
            {
                builder.AppendLine($"【异常类型】：{ex.GetType().Name}");
                builder.AppendLine($"【异常信息】：{ex.Message}");
                builder.AppendLine($"【堆栈调用】：{ex.StackTrace}");
                builder.AppendLine($"【异常方法】：{ex.TargetSite}");
            }
            else
            {
                builder.AppendLine($"【未处理异常】：{backStr}");
            }
            builder.AppendLine("***************************************************************");
            return builder.ToString();
        }
    }
}
