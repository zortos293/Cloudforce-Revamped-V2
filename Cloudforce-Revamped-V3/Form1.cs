using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudforce_Revamped_V3
{
    public partial class Form1 : Form
    {
        DynamicLoader DynamicLoader = new DynamicLoader();
        public Form1()
        {
            InitializeComponent();
        }
        #region Top Bar

        protected void Appsbutton_Click(object sender, EventArgs e)
        {
            Guna2Button button = sender as Guna2Button;
            switch (button.Name)
            {
                case "HomeBTN":
                    FormTabs.SelectedIndex = 0;
                    return;
                case "AppsBTN":
                    FormTabs.SelectedIndex = 1;
                    return;
                case "GamesBTN":
                    FormTabs.SelectedIndex = 2;
                    return;
            }
          
        }

        #endregion


        #region Apps Stuff
        public  void AppsInfo(int JSONint)
        {
            AppInfo myForm = new AppInfo();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.AppsInfoPanel.Controls.Clear();
            this.AppsInfoPanel.Controls.Add(myForm);
            myForm.initalizeApp(JSONint);
            myForm.Show();
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            DynamicLoader.LoadAppButtons(flowLayoutPanel1,this);
        }
    }
}
