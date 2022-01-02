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

    public partial class BrowserForm : Form
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

        public Timer PageLoadedTimer = new Timer();

        public BrowserForm()
        {
            this.InitializeComponent();

            PageLoadedTimer.Interval = 300;
            PageLoadedTimer.Tick += PageLoadedTimer_Tick;

            //Process.Start(Arguments.LoginRedirectUrl);
            this.WebBrowser.Url = new Uri(Arguments.LoginRedirectUrl);

            this.ModeToolStripComboBox.ComboBox.DataSource = this.StartModes.Keys.ToList();
            this.ModeToolStripComboBox.SelectedItem = Settings.Default.StartMode;

            string pass = LauncherSettings.GetValue(LauncherSettings.REMEMBER_PASSWORD);

            if (!string.IsNullOrWhiteSpace(pass))
                tbRememberPassword.Text = pass;
        }

        private void PageLoadedTimer_Tick(object sender, EventArgs e)
        {
            ElementCache.Clear();

            try
            {
                var topbox = WebBrowser.Document.GetElementById("nexonCLogin");
                if (topbox == null)
                    return;
            }
            catch
            {
                return;
            }





            WebBrowser.Document.Body.Style = "background-color: #222222";

           //Put Password in passwordbox
           var passwordBox = WebBrowser.Document.GetElementById("txtCPWD");
            if (passwordBox != null)
            {
                PageLoadedTimer.Stop();

                try
                {
                    if (tbRememberPassword.Text.Trim() != "")
                    {
                        passwordBox.Focus();
                        passwordBox.InnerText = tbRememberPassword.Text;
                    }
                }
                catch { } //eat it

            }



            //Page Cleanup

            try
            {
                var header = GetElementsByAttribMatch("div", "className", "header");
                HideElements(header);

                var gnb = GetElementsByAttribMatch("div", "className", "gnbBarLeft");
                HideElements(header);

                var h1 = WebBrowser.Document.GetElementsByTagName("h1").Cast<HtmlElement>();
                HideElements(h1);

                var forgetPass = GetElementsByAttribMatch("p", "className", "loginMenu");
                HideElements(forgetPass);

                var topbox = WebBrowser.Document.GetElementById("nexonCLogin");
                if (topbox != null)
                    topbox.Style = "padding-top:13px";

                var capcha = GetElementsByAttribMatch("div", "className", "captchaSec");
                foreach (var elem in capcha)
                    elem.Style = "margin: 0 0 0px";

            }
            catch { } //eat it



            //page translation

            try
            {


                var btLogin = GetElementsByAttribMatch("div", "className", "btLogin");
                foreach (var elem in btLogin)
                {
                    //for some reason, the login screen REALLY doesn't like it if you touch the button's text...
                    //elem.InnerHtml = elem.InnerHtml.Replace("넥슨ID 로그인", "Log in");

                    elem.Style = "height: 40px";
                }

                var btnLogin = GetElementsByAttribMatch("button", "className", "button01");
                foreach (var elem in btnLogin)
                {
                    elem.Style = "height: 40px";
                }

            }
            catch { } //eat it

            try
            {
                var labelSaveUser = GetElementsByAttribMatch("div", "className", "saveid").FirstOrDefault();
                if (labelSaveUser != null)
                {
                    labelSaveUser.Style = "top:8px";

                    var actualLabel = labelSaveUser.Children.Cast<HtmlElement>().Last();
                    actualLabel.InnerText = "Remember Nexon ID";
                    actualLabel.Style = "color: #FFFFFF";
                }
            }
            catch { } //eat it


            /* Captcha Changed on Nexon 5/26/2021, removing this functionality, no longer needed.
            try
            {
                var capchaHeader = GetElementsByAttribMatch("p", "className", "captchaMsg");//.FirstOrDefault();

                var idmarge = capchaHeader.FirstOrDefault().Parent.Children.Cast<HtmlElement>().FirstOrDefault(it => it.GetAttribute("className") == "id");

                if (idmarge != null)
                    idmarge.Style = "margin-top:32px";

                HideElements(capchaHeader);

            }
            catch { } //eat it
            */


            WebBrowser.Visible = true;

        }

        public void HideElements(IEnumerable<HtmlElement> elems)
        {
            foreach (var item in elems)
                item.Style = "display:none";
        }

        Dictionary<string, IEnumerable<HtmlElement>> ElementCache = new Dictionary<string, IEnumerable<HtmlElement>>();
        public IEnumerable<HtmlElement> GetElementsByAttribMatch(string elementtype, string attribname, string classname)
        {
            if (!ElementCache.ContainsKey(elementtype))
                ElementCache[elementtype] = WebBrowser.Document.GetElementsByTagName(elementtype).Cast<HtmlElement>();


            var allDivs = ElementCache[elementtype];
            var match = allDivs.Where(it => it.GetAttribute(attribname).Contains(classname));
            return match;
        }

        public IEnumerable<HtmlElement> GetElementsByAttribMatch(IEnumerable<HtmlElement> elements, string elementtype, string attribname, string classname)
        {
            var match = elements.Where(it => it.GetAttribute(attribname).Contains(classname));
            return match;
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
                string architecture = this.StartArchitectures[Architecture.x64];
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
            WebBrowser.Hide();

            this.WebBrowser.Navigate(Arguments.LoginRedirectUrl);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Settings.Default.StartMode = (StartMode)this.ModeToolStripComboBox.SelectedItem;
            Settings.Default.Architecture = Architecture.x64;

            Settings.Default.Save();
        }

        private void lbRememberPassword_TextChanged(object sender, EventArgs e)
        {
            LauncherSettings.SetValue(LauncherSettings.REMEMBER_PASSWORD, tbRememberPassword.Text);
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            var passwordBox = WebBrowser.Document.GetElementById("txtCPWD");
            if (passwordBox != null)
            {
                passwordBox.Focus();
                passwordBox.InnerText = tbRememberPassword.Text;
            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            PageLoadedTimer.Start();
        }
    }
}
