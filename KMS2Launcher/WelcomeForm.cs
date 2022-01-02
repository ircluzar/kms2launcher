using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            string guideUrl = LauncherSettings.GetWebValue(LauncherSettings.GAME_GUIDE);

            if (string.IsNullOrEmpty(guideUrl))
            {
                MessageBox.Show("Could not fetch the guide url");
                return;
            }

            Process.Start(guideUrl);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            string Url = LauncherSettings.GetWebValue(LauncherSettings.DISCORD_LINK);

            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show("Could not fetch the discord url");
                return;
            }

            Process.Start(Url);
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            string Url = LauncherSettings.GetWebValue(LauncherSettings.TRANSLATE_LINK);

            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show("Could not fetch the translation url");
                return;
            }

            Process.Start(Url);
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string githubUrl = LauncherSettings.GetWebValue(LauncherSettings.GITHUB_REPO);

            if (string.IsNullOrEmpty(githubUrl))
            {
                MessageBox.Show("Could not fetch the github url");
                return;
            }

            Process.Start(githubUrl);
        }
    }
}
