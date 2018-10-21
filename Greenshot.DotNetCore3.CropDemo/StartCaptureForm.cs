using Dapplo.Windows.Desktop;
using Greenshot.Addons.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Greenshot.DotNetCore3.CropDemo
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
            var capture = WindowCapture.CaptureRectangleFromDesktopScreen(new Capture(), screenbounds);
            var windows = InteropWindowQuery.GetTopLevelWindows().ToList();
            var form = new CaptureForm(CoreConfiguration.Instance, capture, windows);
            form.ShowDialog();
        }
    }
}
