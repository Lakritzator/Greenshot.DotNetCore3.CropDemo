using Greenshot.Addons.Core;
using System;
using System.Windows.Forms;
using Dapplo.Windows.Desktop;
using System.Linq;
using Dapplo.Windows.Dpi;

namespace Greenshot.DotNetCore3.CropDemo.Net461
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This should not be needed, the app.manifest should do this, but somehow it doesn't
            NativeDpiMethods.EnableDpiAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var screenbounds = WindowCapture.GetScreenBounds();
            var capture = WindowCapture.CaptureRectangleFromDesktopScreen(new Capture(), screenbounds);
            var windows = InteropWindowQuery.GetTopLevelWindows().ToList();
            var form = new CaptureForm(CoreConfiguration.Instance, capture, windows);

            Application.Run(form);
        }
    }
}
