using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudforce_Revamped_V3
{
    public partial class Form1 : Form
    {
        private DynamicLoader DynamicLoader = new DynamicLoader();
        public static bool guest = true;

        public Form1()
        {
            InitializeComponent();
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            if (guest)
            {
                UsernameLBL.Text = "Guest";
            }
            else
            {
                UsernameLBL.Text = LoginTools.KeyAuthApp.user_data.username;
            }
            this.Show();
        }

        #region Top Bar

        protected void Appsbutton_Click(object sender, EventArgs e)
        {
            Guna2Button button = sender as Guna2Button;
            switch (button.Name)
            {
                case "HomeBTN":
                    FormTabs.SelectedIndex = 0;
                    guna2Transition1.ShowSync(FormTabs);
                    return;

                case "AppsBTN":
                    FormTabs.SelectedIndex = 1;
                    guna2Transition1.ShowSync(FormTabs);
                    return;

                case "GamesBTN":
                    FormTabs.SelectedIndex = 2;
                    guna2Transition1.ShowSync(FormTabs);
                    return;
                case "CustomDownloadBTN":
                    FormTabs.SelectedIndex = 3;
                    guna2Transition1.ShowSync(FormTabs);
                    return;
            }
        }

        #endregion Top Bar

        #region Dynamic Stuff

        public void AppsInfo(int JSONint)
        {
            AppInfo myForm = new AppInfo();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.AppsInfoPanel.Controls.Clear();
            guna2Transition2.HideSync(AppsInfoPanel, false, Guna.UI2.AnimatorNS.Animation.Transparent);
            this.AppsInfoPanel.Controls.Add(myForm);
            myForm.initalizeApp(JSONint);
            myForm.Show();
            guna2Transition2.ShowSync(AppsInfoPanel, false, Guna.UI2.AnimatorNS.Animation.Transparent);
        }

        public void GameInfos(int JSONint)
        {
            GameInfo myForm = new GameInfo();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.GameInfo.Controls.Clear();
            guna2Transition2.HideSync(GameInfo, false, Guna.UI2.AnimatorNS.Animation.Transparent);
            this.GameInfo.Controls.Add(myForm);
            myForm.initalizeGame(JSONint);
            myForm.Show();
            guna2Transition2.ShowSync(GameInfo, false, Guna.UI2.AnimatorNS.Animation.Transparent);
        }

        #endregion Dynamic Stuff

        private void Form1_Load(object sender, EventArgs e)
        {
            DynamicLoader.LoadGameButtons(GamesFlowPanel, this);
            DynamicLoader.LoadAppButtons(AppsFlowPanel, this);
        }

        private void allappsPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AppsInfoPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}