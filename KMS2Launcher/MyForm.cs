using System;
using System.Linq;
using System.Windows.Forms;
using KMS2Launcher.Properties;

namespace KMS2Launcher
{
    public class MyForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            if (Settings.Default.IsMaximised)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Screen.AllScreens.Any(s => s.WorkingArea.IntersectsWith(Settings.Default.DesktopBounds)))
            {
                this.StartPosition = FormStartPosition.Manual;
                this.DesktopBounds = Settings.Default.DesktopBounds;
                this.WindowState = FormWindowState.Normal;
            }

            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Settings.Default.IsMaximised = this.WindowState == FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                Settings.Default.DesktopBounds = this.RestoreBounds;
            }
            else
            {
                Settings.Default.DesktopBounds = this.DesktopBounds;
            }

            Settings.Default.Save();

            base.OnFormClosing(e);
        }
    }
}
