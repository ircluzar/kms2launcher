using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using KMS2Launcher.Properties;

namespace KMS2Launcher
{
    public enum StartMode
    {
        Launch,
        Patch,
    }

#pragma warning disable IDE1006 // Naming Styles
    public enum Architecture
    {
        Auto,
        x32,
        x64,
    }
#pragma warning restore IDE1006 // Naming Styles

    public partial class BrowserForm : MyForm
    {
        private const string UrlFormat = "ngm://launch/ -dll:platform.nexon.com/NGM/Bin/NGMDll.dll:1 -locale:{4} -mode:{3} -game:{0}:0 -token:'{1}' -passarg:'null' -a2sk:'{2}' -architectureplatform:'{5}'";

        private readonly Dictionary<StartMode, string> StartModes = new Dictionary<StartMode, string>()
        {
            { StartMode.Launch, "launch" },
            { StartMode.Patch, "restore" },
        };

        private readonly Dictionary<Architecture, string> StartArchitectures = new Dictionary<Architecture, string>()
        {
            { Architecture.Auto, "auto" },
            { Architecture.x32, "x86" },
            { Architecture.x64, "x64" },
        };

        public BrowserForm()
        {
            this.InitializeComponent();

            this.WebBrowser.Url = new Uri(Arguments.LoginRedirectUrl);

            this.ModeToolStripComboBox.ComboBox.DataSource = this.StartModes.Keys.ToList();
            this.ModeToolStripComboBox.SelectedItem = Settings.Default.StartMode;

            this.ArchitectureToolStripComboBox.ComboBox.DataSource = this.StartArchitectures.Keys.ToList();
            this.ArchitectureToolStripComboBox.SelectedItem = Settings.Default.Architecture;
        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Debug.WriteLine($"Navigated: {e.Url}");

            if (sender is WebBrowser webBrowser)
            {
                Dictionary<string, string> cookies = webBrowser.GetCookies();

                if (!cookies.TryGetValue("NPP", out string nppString))
                {
                    return;
                }
                Debug.WriteLine("Found NPP");

                if (!cookies.TryGetValue("A2SK", out string a2skString))
                {
                    return;
                }
                Debug.WriteLine("Found A2SK");

                string mode = this.StartModes[(StartMode)this.ModeToolStripComboBox.SelectedItem];
                string architecture = this.StartArchitectures[(Architecture)this.ArchitectureToolStripComboBox.SelectedItem];
                string locale = Arguments.StartLocale;
                string launchUri = String.Format(UrlFormat, Arguments.GameId, nppString, a2skString, mode, locale, architecture);
                string escapedUri = Uri.EscapeUriString(launchUri);
                
                webBrowser.AllowNavigation = false;
                webBrowser.Visible = false;

                this.EndBrowsing(escapedUri);
            }
        }

        private void EndBrowsing(string url)
        {
            this.Visible = false;

            try
            {
                Process.Start(url);
            }
            finally
            {
                Application.Exit();
            }
        }

        private void LoginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WebBrowser.Navigate(Arguments.LoginRedirectUrl);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Settings.Default.StartMode = (StartMode)this.ModeToolStripComboBox.SelectedItem;
            Settings.Default.Architecture = (Architecture)this.ArchitectureToolStripComboBox.SelectedItem;

            Settings.Default.Save();
        }
    }
}
