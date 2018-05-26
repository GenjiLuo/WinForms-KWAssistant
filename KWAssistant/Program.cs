using KWAssistant.Form;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CefSharp;

namespace KWAssistant
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            #region 应用程序的主入口点
            AppDomain.CurrentDomain.AssemblyResolve += Resolver;
            Init(); //初始化CefSharp

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            #endregion
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void Init()
        {
            //High DPI Support
            Cef.EnableHighDPISupport();

            var settings = new CefSettings
            {
                BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                    Environment.Is64BitProcess ? "x64" : "x86",
                    "CefSharp.BrowserSubprocess.exe"),
                Locale = "zh-CN",
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36"
            };

#if !DEBUG
            settings.LogSeverity = LogSeverity.Disable;
#endif

            // Make sure you set performDependencyCheck false
            Cef.Initialize(settings, false, null);
        }

        // Will attempt to load missing assembly from either x86 or x64 subdir
        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (!args.Name.StartsWith("CefSharp")) return null;
            var assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
            var archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                Environment.Is64BitProcess ? "x64" : "x86",
                assemblyName);
            return File.Exists(archSpecificPath)
                ? Assembly.LoadFile(archSpecificPath)
                : null;
        }
    }
}
