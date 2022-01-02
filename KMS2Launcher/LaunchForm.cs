using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class LaunchForm : Form
    {

        public BrowserForm bform = null;

        public LaunchForm()
        {
            InitializeComponent();

            if (bform == null)
            {
                bform = new BrowserForm();
                bform.TopLevel = false;
                bform.FormBorderStyle = FormBorderStyle.None;
                Controls.Add(bform);
                bform.Dock = DockStyle.Fill;
                bform.Show();
            }
        }
    }
}
