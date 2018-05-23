using CefSharp;
using CefSharp.WinForms;
using KWAssistant.Form;
using System;

namespace KWAssistant.Util
{
    class LifeSpanHandler : ILifeSpanHandler
    {
        //覆盖原来的新开窗口行为，便于控制
        bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;

            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;

            chromiumWebBrowser.Invoke(new Action(() =>
            {
                if (chromiumWebBrowser.FindForm() is BrowserForm owner)
                {
                    var popup = new BrowserForm(targetUrl, true, owner.Visible);
                    owner.AddOwnedForm(popup);
                    var rect = popup.ClientRectangle;
                    popup.CreateControl();
                    windowInfo.SetAsChild(popup.Handle, rect.Left, rect.Top, rect.Right, rect.Bottom);
                }
            }));

            return false;
        }

        bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser) { return false; }

        void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }

        void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
    }
}