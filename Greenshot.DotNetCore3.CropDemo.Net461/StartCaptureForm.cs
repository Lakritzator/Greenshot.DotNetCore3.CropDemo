using Dapplo.Windows.Desktop;
using Greenshot.Addons.Core;
using Greenshot.Addons.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Greenshot.DotNetCore3.CropDemo.Net461
{
    public partial class StartCaptureForm : Form
    {
        public StartCaptureForm()
        {
            InitializeComponent();
        }

        private void ButtonCapture_Click(object sender, EventArgs e)
        {
            var screenbounds = WindowCapture.GetScreenBounds();
            var capture = new Capture();
            capture.CaptureDetails.CaptureMode = CaptureMode.Region;
            WindowCapture.CaptureRectangleFromDesktopScreen(capture, screenbounds);
            var windows = InteropWindowQuery.GetTopLevelWindows().ToList();
            var form = new CaptureForm(CoreConfiguration.Instance, capture, windows);
            form.ShowDialog();
        }
    }
}
