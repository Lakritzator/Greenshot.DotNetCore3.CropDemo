using Greenshot.Addons.Core;
using System;
using System.Windows.Forms;
using Dapplo.Windows.Desktop;
using System.Linq;
using Dapplo.Windows.Dpi;
using Dapplo.Log;
using Dapplo.Log.Loggers;

namespace Greenshot.DotNetCore3.CropDemo.Net461
{
    static class Program
    {
        private static readonly LogSource Log = new LogSource();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogSettings.RegisterDefaultLogger<DebugLogger>(LogLevels.Verbose);

            // This should not be needed, the app.manifest should do this, but somehow it doesn't
            //NativeDpiMethods.EnableDpiAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var startCaptureForm = new StartCaptureForm();
            Application.Run(startCaptureForm);
        }
    }
}
