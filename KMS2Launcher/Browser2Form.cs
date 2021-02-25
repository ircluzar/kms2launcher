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

using Microsoft.Web.WebView2.Core;

namespace KMS2Launcher
{
    public partial class Browser2Form : Form
    {
        private string gameId;

        // predefine values
        private readonly Dictionary<StartMode, string> startModes = new Dictionary<StartMode, string>()
        {
            { StartMode.Launch, "launch" },
            { StartMode.Patch, "restore" },
        };
        private readonly Dictionary<Architecture, string> startArchitectures = new Dictionary<Architecture, string>()
        {
            { Architecture.Auto, "auto" },
            { Architecture.x32, "x86" },
            { Architecture.x64, "x64" },
        };

        private string lastURL;
        private const string gameRedirectBase = "https://game.nexon.com/";
        private const string loginPOSTBase = "https://login.nexon.com/login/page/loginproc.aspx";
        private const string loginPageBase = "https://nxlogin.nexon.com/common/login.aspx";
        private const string urlFormula = "ngm://launch/ -dll:platform.nexon.com/NGM/Bin/NGMDll.dll:1 -locale:{4} -mode:{3} -game:{0}:0 -token:'{1}' -passarg:'null' -a2sk:'{2}' -architectureplatform:'{5}'";

        public Browser2Form(string gid)
        {
            this.gameId = gid;
            InitializeComponent();
            // init webview
            lastURL = getLoginPage(gameId);
            this.loginWebview.Source = new Uri(lastURL);

            // add navigation event
            loginWebview.NavigationStarting += onNavigationStart;
            loginWebview.NavigationCompleted += onNavigationComplete;
            Debug.WriteLine("[Webview2] Version: " + loginWebview.ProductVersion);
            // combobox
            launchTypeSelectBox.DisplayMember = "Key";
            launchTypeSelectBox.ValueMember = "Value";
            launchTypeSelectBox.DataSource = new BindingSource(startModes, null);
            launchTypeSelectBox.SelectedIndex = 0;
            
        }

        private void onNavigationStart(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            Debug.WriteLine("[Webview2] NavigationStarting - URL: " + args.Uri);
            
            lastURL = args.Uri;
            if (args.Uri.StartsWith(gameRedirectBase))
            {
                args.Cancel = true;
            }
        }
        private async void onNavigationComplete(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            Debug.WriteLine("[Webview2] NavigationCompleted - success: " + args.IsSuccess);
            if (lastURL.StartsWith(loginPageBase))
            {
                await loginWebview.ExecuteScriptAsync(@"
const queryFirst = (clzname) => {
    const arr = document.getElementsByClassName(clzname);
    return arr.length <= 0 ? null : arr[0];
}
const hideElement = (el) => el != null ? (el.style.setProperty(`display`, `none`, `important`)) : (null);
for (const clz of [`captchaMsg`, `gnbWrapper`, `header`, `footer`]) hideElement(queryFirst(clz));
queryFirst(`id`).style.marginTop = `0px`;
queryFirst(`btLogin`).style.setProperty(`position`, `fixed`);
queryFirst(`btLogin`).style.setProperty(`bottom`, `0`);
document.getElementById(`txtNexonID`).placeholder = `Please input your id.`;
document.getElementById(`txtPWD`).placeholder = `Please input your password.`;
document.getElementById(`btnLogin`).innerHTML = `<span>Nexon ID Login</span>`;
");
            } else if (lastURL.StartsWith(gameRedirectBase) && !args.IsSuccess)
            {
                Debug.WriteLine("[Webview2] Logined.");
                launchTypeSelectBox.Enabled = false;

                var cookies = await loginWebview.CoreWebView2.CookieManager.GetCookiesAsync(lastURL);
                string a2sk = "";
                string npp = "";
                foreach (var cookie in cookies)
                {
                    if (a2sk.Length > 0 && npp.Length > 0)
                    {
                        break;
                    }
                    if (cookie.Name == "A2SK")
                    {
                        a2sk = cookie.Value.Trim();
                    } else if (cookie.Name == "NPP")
                    {
                        npp = cookie.Value.Trim();
                    }
                }
                loginWebview.Stop();
                loginWebview.Hide();
                if (a2sk.Length > 0 && npp.Length > 0)
                {
                    Debug.WriteLine("[Cookie] A2SK & NPP valid.");
                    var selected = (KeyValuePair<StartMode, string>) this.launchTypeSelectBox.SelectedItem;
                    startModes.TryGetValue(selected.Key, out string modeParam);
                    _ = Task.Run(() =>
                    {
                        // Launch game
                        Debug.WriteLine("Mode: " + modeParam);
                        string mode = modeParam;
                        string architecture = this.startArchitectures[Architecture.x64];
                        string locale = Arguments.StartLocale;
                        string launchUri = String.Format(urlFormula, gameId, npp, a2sk, mode, locale, architecture);
                        string escapedUri = Uri.EscapeUriString(launchUri);
                        try
                        {
                            Process.Start(escapedUri);
                        }
                        finally
                        {
                            Application.Exit();
                        }
                    });
                } else
                {
                    Debug.WriteLine("[Cookie] A2SK & NPP invalid.");

                    _ = Task.Run(() =>
                      {
                          MessageBox.Show("Getting cookie is failed! Ask developer to fix bug.");
                          Application.Exit();
                      });
                    
                }
            }
        }

        private async Task<string> getCookie()
        {
            var cookies = await loginWebview.CoreWebView2.CookieManager.GetCookiesAsync(lastURL);
            foreach(var cookie in cookies)
            {
                Debug.WriteLine("[Cookie-" + cookie.Path + "] " + cookie.Name + " : " + cookie.Value);
            }
            return "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string getLoginPage(string gameId)
        {
            return loginPageBase + "?redirect=" + gameRedirectBase + gameId;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
