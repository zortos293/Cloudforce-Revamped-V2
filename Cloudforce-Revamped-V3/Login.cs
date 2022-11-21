using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cloudforce_Revamped_V3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginTools.KeyAuthApp.init();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoginTools.KeyAuthApp.login(UsernameLBL.Text, PassLBL.Text);
            if (!LoginTools.KeyAuthApp.response.success)
            {
                ErrorLBL.Text = LoginTools.KeyAuthApp.response.message;
                return;
            }
            else
            {
                if (RememberSwitch.Checked)
                {
                    File.WriteAllText(Path.GetTempPath() + "j2o19j19u2.txt", UsernameLBL.Text + "," + PassLBL.Text);
                }
                Form1.guest = false;
                this.Hide();
            }
           
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetTempPath() + "j2o19j19u2.txt"))
            {
                string[] a = File.ReadAllText(Path.GetTempPath() + "j2o19j19u2.txt").Split(',');
                LoginTools.KeyAuthApp.login(a[0], a[1]);
                if (!LoginTools.KeyAuthApp.response.success)
                {
                    ErrorLBL.Text = LoginTools.KeyAuthApp.response.message;
                    return;
                }
                else
                {
                    Form1.guest = false;
                    this.Hide();
                }
            }
        }
    }
}
