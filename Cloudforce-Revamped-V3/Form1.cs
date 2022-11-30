using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Sentry;
using System.IO.Compression;
using System.Diagnostics;
using System.Drawing;
using Cloudforce_Revamped_V3.Properties;
using System.ComponentModel;
using System.Security.Policy;
using System.Windows.Shapes;

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

                case "RequestBTN":
                    FormTabs.SelectedIndex = 4;
                    guna2Transition1.ShowSync(FormTabs);
                    return;

                case "RequestAPPBTN":
                    FormTabs.SelectedIndex = 5;
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

        #region Request

        public class Game
        {
            public string GameName { get; set; }
            public string GameImage { get; set; }
            public string GameIcon { get; set; }
            public string GameDescription { get; set; }
            public string GameSize { get; set; }
            public string GameDownloadCloudURL { get; set; }
            public string GameDownloadURL { get; set; }
            public string GameExe { get; set; }
            public string GameArguments { get; set; }
            public string GameUpdateLog { get; set; }
            public bool GamePaid { get; set; }
        }

        public class App
        {
            public string AppName { get; set; }
            public string AppImage { get; set; }
            public string AppDescription { get; set; }
            public string AppGFNIssues { get; set; }
            public string AppGFNStatus { get; set; }
            public string AppDownloadUrl { get; set; }
            public string AppExe { get; set; }
            public string AppArguments { get; set; }
            public string AppUpdateLog { get; set; }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GameNameTXT.Text) && !string.IsNullOrEmpty(GameImageTXT.Text) && !string.IsNullOrEmpty(GameIconTXT.Text) && !string.IsNullOrEmpty(GameDownloadURLTXT.Text) && !string.IsNullOrEmpty(GameSizeTXT.Text) && !string.IsNullOrEmpty(GameExeTXT.Text))
            {
                DateTime now = DateTime.Now;
                // add items to the list
                Game game = new Game();
                game.GameName = GameNameTXT.Text;
                game.GameImage = GameImageTXT.Text;
                game.GameIcon = GameIconTXT.Text;
                game.GameDescription = GameDownloadURLTXT.Text;

                game.GameDownloadCloudURL = "";
                game.GameDownloadURL = GameDownloadURLTXT.Text;
                if (GameSizeCOMBO.SelectedIndex == 0)
                {
                    game.GameSize = GameSizeTXT.Text + " GB";
                }
                else if (GameSizeCOMBO.SelectedIndex == 1)
                {
                    game.GameSize = GameSizeTXT.Text + " MB";
                }
                game.GameExe = GameExeTXT.Text;
                game.GameArguments = "";
                game.GameUpdateLog = now.ToString("d") + "\n-------------------------------\nAdded " + GameNameTXT.Text;
                game.GamePaid = false;
                string output = JsonConvert.SerializeObject(game);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://178.62.250.139:5000/api/request_game/" + UsernameLBL.Text);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(output);
                }

                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    MessageBox.Show("Your Game Request has been succesfully send!");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("429"))
                    {
                        MessageBox.Show("Too many Requests! Wait 1 minute then try again");
                    }
                    else
                    {
                        MessageBox.Show("Something Went wrong!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AppNameTXT.Text) && !string.IsNullOrEmpty(AppIconTXT.Text) && !string.IsNullOrEmpty(AppGFNTXT.Text) && !string.IsNullOrEmpty(AppExeTXT.Text) && !string.IsNullOrEmpty(AppDownloadTXT.Text))
            {
                DateTime now = DateTime.Now;
                // add items to the list
                App app = new App();
                app.AppName = AppNameTXT.Text;
                app.AppImage = AppIconTXT.Text;
                app.AppDownloadUrl = AppDownloadTXT.Text;

                app.AppDescription = AppDescriptionTXT.Text;
                app.AppGFNIssues = AppGFNTXT.Text;
                if (AppGfnCOMBO.SelectedIndex == 0)
                {
                    app.AppGFNStatus = "Safe";
                }
                else if (AppGfnCOMBO.SelectedIndex == 1)
                {
                    app.AppGFNStatus = "Unsafe";
                }
                else if (AppGfnCOMBO.SelectedIndex == 2)
                {
                    app.AppGFNStatus = "Crash";
                }
                app.AppExe = GameExeTXT.Text;
                app.AppArguments = "";
                app.AppUpdateLog = now.ToString("d") + "\n-------------------------------\nAdded " + GameNameTXT.Text;

                string output = JsonConvert.SerializeObject(app);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://178.62.250.139:5000/api/request_app/" + UsernameLBL.Text);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(output);
                }

                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    MessageBox.Show("Your App Request has been succesfully send!");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("429"))
                    {
                        MessageBox.Show("Too many Requests! Wait 1 minute then try again");
                    }
                    else
                    {
                        MessageBox.Show("Something Went wrong!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }

        #endregion Request

        #region Download

        public static string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\";

        private void guna2Button3_Click(object sender, EventArgs e) // Download
        {
            var username = Environment.UserName;
            var download_link = guna2TextBox3.Text;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxysz";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var exe_name = new String(stringChars);
            Uri uriResult;
            bool result = Uri.TryCreate(download_link, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (download_link == "" || download_link == " " || result == false)
            {
                DownloadLBL.Text = "Please put a valid download link in the input field.";
                DownloadLBL.ForeColor = Color.Red;
                guna2TextBox1.PlaceholderForeColor = Color.Red;
                guna2TextBox1.PlaceholderText = "Invalid link.";
                guna2TextBox1.Text = "";
            }
            else
            {
                Boolean dresult = download_link.Contains(".zip");
                if (dresult == true)
                {
                    try
                    {
                        File_Downloader(download_link, mainpath + $"\\{exe_name}.zip", guna2Button3);
                        DownloadLBL.Text = $"Downloaded: C:\\users\\{username}\\AppData\\Roaming\\Cloudforce\\{exe_name}.zip";
                        guna2TextBox3.Text = $"C:\\users\\{username}\\AppData\\Roaming\\Cloudforce\\{exe_name}.zip";
                    }
                    catch
                    {
                        DownloadLBL.Text = "An error occured while trying to download.";
                        guna2TextBox3.Text = "";
                        DownloadLBL.ForeColor = Color.Red;
                        guna2TextBox3.ForeColor = Color.Red;
                        guna2TextBox3.PlaceholderText = "Invalid link.";
                        guna2TextBox3.Text = "";
                    }
                }
                else
                {
                    try
                    {
                        File_Downloader(download_link, mainpath + $"\\{exe_name}.exe", guna2Button3);
                        DownloadLBL.Text = $"Downloaded: {mainpath}\\{exe_name}.exe";
                        guna2TextBox2.Text = $"C:\\users\\{username}\\AppData\\Roaming\\Cloudforce\\{exe_name}.exe";
                    }
                    catch
                    {
                        DownloadLBL.Text = "An error occured while trying to download.";
                        guna2TextBox3.Text = "";
                        DownloadLBL.ForeColor = Color.Red;
                        guna2TextBox3.PlaceholderForeColor = Color.Red;
                        guna2TextBox3.PlaceholderText = "Invalid link.";
                        guna2TextBox3.Text = "";
                    }
                }
                guna2TextBox3.PlaceholderText = "Link here";
                guna2TextBox3.Text = "";
            }
        }

        private async void guna2Button4_Click(object sender, EventArgs e) // Extract
        {
            var username = Environment.UserName;
            var extract_path = guna2TextBox1.Text;
            if (extract_path == "" || extract_path == " " || File.Exists(extract_path) == false || extract_path.Contains(".zip") == false)
            {
                DownloadLBL.Text = "Please put a valid path in the input field.";
                DownloadLBL.ForeColor = Color.Red;
                guna2TextBox1.PlaceholderForeColor = Color.Red;
                guna2TextBox1.PlaceholderText = "Invalid path.";
                guna2TextBox1.Text = "";
            }
            else
            {
                try
                {
                    await Task.Run(() =>
                    {
                        ZipFile.ExtractToDirectory($@"{extract_path}", $@"C:\users\{username}\AppData\Roaming\Cloudforce");
                    });
                    DownloadLBL.Text = $"[-] Extracted: {extract_path}";
                    guna2TextBox2.Text = $"C:\\users\\{username}\\AppData\\Roaming\\Cloudforce\\";
                    guna2TextBox1.Text = "";
                }
                catch
                {
                    DownloadLBL.Text = "Failed to extract zip.";
                    DownloadLBL.ForeColor = Color.Red;
                    guna2TextBox1.PlaceholderForeColor = Color.Red;
                    guna2TextBox1.PlaceholderText = "Failed to extract";
                    guna2TextBox1.Text = "";
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e) // Run
        {
            var run_path = guna2TextBox2.Text;
            if (run_path == "" || run_path == " " || File.Exists(run_path) == false || run_path.Contains(".exe") == false)
            {
                DownloadLBL.Text = "Please put a valid path in the input field.";
                DownloadLBL.ForeColor = Color.Red;
                guna2TextBox2.PlaceholderForeColor = Color.Red;
                guna2TextBox2.PlaceholderText = "Invalid path.";
                guna2TextBox2.Text = "";
            }
            else
            {
                try
                {
                    new Process()
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            WorkingDirectory = $"{mainpath}\\",
                            WindowStyle = ProcessWindowStyle.Normal,
                            FileName = run_path,
                        }
                    }.Start();
                    DownloadLBL.Text = $"[-] Started {run_path}";
                }
                catch
                {
                    DownloadLBL.Text = "Failed to start exe.";
                    DownloadLBL.ForeColor = Color.Red;
                    guna2TextBox2.PlaceholderForeColor = Color.Red;
                    guna2TextBox2.PlaceholderText = "Failed to start";
                    guna2TextBox2.Text = "";
                }
            }
        }

        #endregion Download

        #region Downloader

        private bool DownloadFinished;

        public void File_Downloader(string URL, string path, Guna2Button button)
        {
            // download file with progress bar
            DownloadFinished = false;
            WebClient client = new WebClient();
            button.Invoke(new MethodInvoker(delegate { button.Enabled = false; }));
            Progressbar.Invoke(new MethodInvoker(delegate { Progressbar.Value = 0; }));
            Progressbar.Invoke(new MethodInvoker(delegate { Progressbar.Visible = true; }));
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadChanged);
            client.DownloadFileAsync(new Uri(URL), path);
            while (DownloadFinished == false)
                Application.DoEvents();
        }

        private async void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DownloadFinished = true;
                Progressbar.Invoke(new MethodInvoker(delegate { Progressbar.Visible = false; }));
                Progressbar.Invoke(new Action(() => Progressbar.Value = 0));

                ((WebClient)sender).Dispose();
            }
            else
            {
                SentrySdk.CaptureException(e.Error);
                MessageBox.Show(e.Error.Message);
                Progressbar.Invoke(new Action(() => Progressbar.Visible = false));
                guna2Button3.Invoke(new Action(() => guna2Button3.Enabled = true));
            }
        }

        private void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Progressbar.Invoke(new Action(() => Progressbar.Value = e.ProgressPercentage));
            guna2Button3.Invoke(new Action(() => guna2Button3.Text = "Downloading " + e.ProgressPercentage + "%"));
        }

        #endregion Downloader
    }
}