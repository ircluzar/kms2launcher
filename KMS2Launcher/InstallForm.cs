using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class InstallForm : Form
    {
        public InstallForm()
        {
            InitializeComponent();
        }

        private void btnDownloadInstall_Click(object sender, EventArgs e)
        {
            string downloadUrl = LauncherSettings.GetWebValue(LauncherSettings.INSTALLER_URL);
            string filename = downloadUrl.Substring(downloadUrl.LastIndexOf('/') + 1);
            string tempPath = Path.Combine(LauncherSettings.TempDir, filename);

            KillProcess(filename);

            DownloadForm.DownloadFile(downloadUrl, tempPath, null);
        }

        public void KillProcess(string name)
        {
            //wmic is safer than taskkill but it's also async so...

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "wmic";
            psi.Arguments = $"process where name='{name}' delete";
            Process.Start(psi).WaitForExit();
            Thread.Sleep(420);
        }

        private void btnOpenGuide2_Click(object sender, EventArgs e)
        {
            string guideUrl = LauncherSettings.GetWebValue(LauncherSettings.GAME_GUIDE);

            if (string.IsNullOrEmpty(guideUrl))
            {
                MessageBox.Show("Could not fetch the guide url");
                return;
            }

            Process.Start(guideUrl);
        }
    }
}
