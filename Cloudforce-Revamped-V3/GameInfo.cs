using Cloudforce_Revamped_V3.Properties;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using Sentry;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudforce_Revamped_V3
{
    public partial class GameInfo : Form
    {
        public int CurentAppJSONInt;
        public static string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\";
        private GameDownloader gamedownloader = new GameDownloader();

        public GameInfo()
        {
            InitializeComponent();
        }

        public void initalizeGame(int json) // Adds All the info's and stuffs :)
        {
            CurentAppJSONInt = json;
            GameDescriptionLBL.Clear();
            GameDescriptionLBL.AppendText(GamesJSON.GameJSON.Games[json].GameDescription);
            GameNameLBL.Text = GamesJSON.GameJSON.Games[json].GameName;
            GameImage.Load(GamesJSON.GameJSON.Games[json].GameImage);
            GameImage.Refresh();
            GameUpdateLBL.Text = GamesJSON.GameJSON.Games[json].GameUpdateLog;
            if (File.Exists(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe))
            {
                DownloadBTN.FillColor = Color.FromArgb(255, 65, 138, 238);
                DownloadBTN.FillColor2 = Color.FromArgb(255, 60, 131, 237);
                DownloadBTN.Image = Resources.play_96px;
                DownloadBTN.Text = "Start";
            }
            GameSizeLBL.Text = GamesJSON.GameJSON.Games[json].GameSize;
        }

        private async void DownloadBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL))
            {
                if (proccesrun() == false)
                {
                    await Task.Run(() =>
                    {
                        File_Downloader(DownloadBTN);
                    });
                }
            }
            else
            {
                if (!gamedownloader.startgame(CurentAppJSONInt))
                {
                    gamedownloader.DownloadGame(CurentAppJSONInt, Progressbar, guna2HtmlLabel1, DownloadBTN);
                }
            }
        }

        #region Normal Download Stuff

        public bool exractdone = false;
        private bool DownloadFinished;

        public void File_Downloader(Guna2GradientButton button)
        {
            // download file with progress bar
            DownloadFinished = false;
            WebClient client = new WebClient();
            button.Invoke(new MethodInvoker(delegate { button.Enabled = false; }));
            Progressbar.Invoke(new MethodInvoker(delegate { Progressbar.Value = 0; }));
            Progressbar.Invoke(new MethodInvoker(delegate { Progressbar.Visible = true; }));
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadChanged);
            client.DownloadFileAsync(new Uri(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL), mainpath + Path.GetExtension(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL));
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
                if (GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL.EndsWith(".zip")) // IF file is zip Extract
                {
                    await Task.Run(() =>
                    {
                        exractdone = false;
                        DownloadBTN.Invoke(new Action(() => DownloadBTN.Text = "Extracting"));

                        ZipFile.ExtractToDirectory(mainpath + Path.GetExtension(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL), mainpath);
                        exractdone = true;
                    });
                    while (exractdone == false)
                    {
                        Application.DoEvents();
                    }
                    File.Delete(mainpath + Path.GetExtension(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL));
                }
                else
                {
                    if (GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe.EndsWith(".exe") && !GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe.StartsWith("c:\\"))
                    {
                        if (Path.GetExtension(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL) != GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe)
                        {
                            File.Move(mainpath + Path.GetExtension(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameDownloadURL), mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe);
                        }
                    }
                }
                if (File.Exists(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe)) // Changes Icon and color to blue and changes the text to start
                {
                    DownloadBTN.Invoke(new Action(() => DownloadBTN.FillColor = Color.FromArgb(255, 65, 138, 238)));
                    DownloadBTN.Invoke(new Action(() => DownloadBTN.FillColor2 = Color.FromArgb(255, 60, 131, 237)));
                    DownloadBTN.Invoke(new Action(() => DownloadBTN.Image = Resources.play_96px));
                    DownloadBTN.Invoke(new Action(() => DownloadBTN.Text = "Start"));
                    DownloadBTN.Invoke(new Action(() => DownloadBTN.Enabled = true));
                }
                // -------------------------------------------------------------------------------------
                //                                  Custom Patches (Apps)
                // -------------------------------------------------------------------------------------
                //switch (GamesJSON.GameJSON.Games[CurentAppJSONInt].GameName)
                //{
                //}
                // -------------------------------------------------------------------------------------
                //                                  Custom Patches END
                // -------------------------------------------------------------------------------------
                if (GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe.StartsWith("C:\\"))
                {
                    Process.Start(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe, GamesJSON.GameJSON.Games[CurentAppJSONInt].GameArguments);
                    return;
                }
                else
                {
                    Process.Start(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe, GamesJSON.GameJSON.Games[CurentAppJSONInt].GameArguments);
                }
            }
            else
            {
                SentrySdk.CaptureException(e.Error);
                MessageBox.Show(e.Error.Message);
                Progressbar.Invoke(new Action(() => Progressbar.Visible = false));
                DownloadBTN.Invoke(new Action(() => DownloadBTN.Enabled = true));
            }
        }

        private void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Progressbar.Invoke(new Action(() => Progressbar.Value = e.ProgressPercentage));
            DownloadBTN.Invoke(new Action(() => DownloadBTN.Text = "Downloading " + e.ProgressPercentage + "%"));
        }

        public bool proccesrun()
        {
            // Custom Launch Stuff
            switch (GamesJSON.GameJSON.Games[CurentAppJSONInt].GameName)
            {
                case "Lunar Client":
                    if (File.Exists(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe))
                    {
                        Process.Start($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Programs\\lunarclient\\Lunar Client.exe");
                        return true;
                    }
                    return false;

                case "Roblox":
                    if (File.Exists(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe))
                    {
                        Process.Start($@"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Roblox\\Roblox Player.lnk");
                        return true;
                    }
                    return false;
            }

            // End Custom Launch Stuff

            if (File.Exists(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe))
            {
                Process.Start(GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe, GamesJSON.GameJSON.Games[CurentAppJSONInt].GameArguments);
                return true;
            }
            if (File.Exists(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe))
            {
                Process.Start(mainpath + GamesJSON.GameJSON.Games[CurentAppJSONInt].GameExe, GamesJSON.GameJSON.Games[CurentAppJSONInt].GameArguments);
                return true;
            }
            else return false;
        }

        #endregion Normal Download Stuff
    }
}