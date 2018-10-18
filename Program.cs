using Greenshot.Addons.Core;
using System;
using System.Windows.Forms;
using Dapplo.Windows.Desktop;
using System.Linq;

namespace Greenshot.DotNetCore3.CropDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var capture = WindowCapture.CaptureRectangleFromDesktopScreen(new Capture(), WindowCapture.GetScreenBounds());
            var windows = InteropWindowQuery.GetTopLevelWindows().ToList();
            var form = new CaptureForm(CoreConfiguration.Instance, capture, windows);

            Application.Run(form);
        }
    }
}
