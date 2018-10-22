using System;
using System.Windows.Forms;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var startCaptureForm = new StartCaptureForm();
            Application.Run(startCaptureForm);
        }
    }
}
