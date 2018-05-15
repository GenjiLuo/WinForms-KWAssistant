using KWAssistant.Form;
using System;
using System.Windows.Forms;

namespace KWAssistant
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 应用程序的主入口点
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            #endregion
        }
    }
}
