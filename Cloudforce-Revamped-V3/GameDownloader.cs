using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cloudforce_Revamped_V3.GamesJSON;

namespace Cloudforce_Revamped_V3
{
    internal class GameDownloader
    {
        private bool Done = true;
        public static string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\";
        private Guna2ProgressBar progressbar = new Guna2ProgressBar();
        private Guna2HtmlLabel label = new Guna2HtmlLabel();
        private Guna2GradientButton downloadbutton = new Guna2GradientButton();
        private int currentjsonint;

        public async void DownloadGame(int JsonNumber, Guna2ProgressBar progressBar, Guna2HtmlLabel htmllabel, Guna2GradientButton DownloadBTN) // Download Game <<<<
        {
            if (Done == false)
            {
                MessageBox.Show("Cant Download while something is downloading");
                return;
            }
            var username = Environment.UserName;
            WebClient client = new WebClient();

            if (!File.Exists(mainpath + "downloader.exe"))
            {
                Directory.CreateDirectory($"C:\\Users\\{username}\\.config\\");
                Directory.CreateDirectory($"C:\\Users\\{username}\\.config\\rclone\\");
                client.DownloadFile("https://raw.githubusercontent.com/zortos293/ZortosCDN/master/rclone.conf", $"C:\\Users\\{username}\\.config\\rclone\\rclone.conf");
                client.DownloadFile("https://picteon.dev/files/rclone.exe", mainpath + "downloader.exe");
            }
            progressBar.Invoke(new Action(() => progressBar.Visible = true));
            htmllabel.Invoke(new Action(() => htmllabel.Visible = true));

            Process process = new Process();
            progressbar = progressBar;
            label = htmllabel;
            downloadbutton = DownloadBTN;
            currentjsonint = JsonNumber;
            process.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
            process.StartInfo.FileName = mainpath + "downloader.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (GameJSON.Games[JsonNumber].GamePaid)
            {
                if (LoginTools.SubExist("premium"))
                {
                    process.StartInfo.Arguments = LoginTools.KeyAuthApp.var("Gdrive") + GameJSON.Games[JsonNumber].GameDownloadCloudURL + " " + mainpath + GameJSON.Games[JsonNumber].GameDownloadCloudURL;
                }
                else
                {
                    MessageBox.Show("You need to be premium to download this game");
                    return;
                }
            }
            else
            {
                if (LoginTools.SubExist("premium") || LoginTools.SubExist("booster"))
                {
                    MessageBox.Show("Using Google Drive (Premium)");
                    process.StartInfo.Arguments = LoginTools.KeyAuthApp.var("Gdrive") + GameJSON.Games[JsonNumber].GameDownloadCloudURL + " " + mainpath + GameJSON.Games[JsonNumber].GameDownloadCloudURL;
                }
                else
                {
                    process.StartInfo.Arguments = "copy -P --transfers=4 --checkers=16 " + "zortosdrive:\\" + GameJSON.Games[JsonNumber].GameDownloadCloudURL + " " + mainpath + GameJSON.Games[JsonNumber].GameDownloadCloudURL;
                }
            }

            Done = false;
            Done = false;
            process.Exited += new EventHandler(p_Exited);
            process.EnableRaisingEvents = true;

            process.Start();
            process.BeginOutputReadLine();
            while (Done == false)
            {
                Application.DoEvents();
            }
            // ----------------------------------------------------------------------------------------------------------
            //                                                  Custom Patches (After game Download)
            // ----------------------------------------------------------------------------------------------------------
            if (GameJSON.Games[currentjsonint].GameName == "Overwatch" && !LoginTools.SubExist("premium") && !LoginTools.SubExist("booster")) // Overwatch
            {
                Process process1 = new Process();
                Done = false;
                process1.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                process1.StartInfo.FileName = mainpath + "downloader.exe";
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.RedirectStandardOutput = true;
                process1.StartInfo.RedirectStandardError = false;
                process1.StartInfo.CreateNoWindow = true;
                process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process1.StartInfo.Arguments = LoginTools.KeyAuthApp.var("Gdrivef") + "dataOverwatch\\" + " " + mainpath + GameJSON.Games[JsonNumber].GameDownloadCloudURL + "data\\casc\\data\\";
                process1.Exited += new EventHandler(p_Exited);
                process1.EnableRaisingEvents = true;
                progressBar.Invoke(new Action(() => progressBar.Visible = true));
                htmllabel.Invoke(new Action(() => htmllabel.Visible = true));
                process1.Start();
                process1.BeginOutputReadLine();
                while (Done == false)
                {
                    Application.DoEvents();
                }
                bool extractdone = false;
                DownloadBTN.Invoke(new Action(() => DownloadBTN.Text = "Extracting"));
                await Task.Run(() =>
                {
                    ZipFile.ExtractToDirectory(mainpath + "Overwatch\\data\\casc\\indices\\indices.zip", mainpath + "Overwatch\\data\\casc\\indices\\");
                    extractdone = true;
                });
                while (extractdone == false)
                {
                    Application.DoEvents();
                }
                bool a = startgame(currentjsonint);
            }
            if (GameJSON.Games[currentjsonint].GameName == "Fall Guys" && LoginTools.SubExist("premium")) // Fall Guys
            {
                Process process1 = new Process();
                Done = false;
                process1.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                process1.StartInfo.FileName = mainpath + "downloader.exe";
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.RedirectStandardOutput = true;
                process1.StartInfo.RedirectStandardError = false;
                process1.StartInfo.CreateNoWindow = true;
                process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process1.StartInfo.Arguments = LoginTools.KeyAuthApp.var("Gdrive") + "EpicGames.zip" + " " + mainpath;
                process1.Exited += new EventHandler(p_Exited);
                process1.EnableRaisingEvents = true;
                progressBar.Invoke(new Action(() => progressBar.Visible = true));
                htmllabel.Invoke(new Action(() => htmllabel.Visible = true));
                process1.Start();
                process1.BeginOutputReadLine();
                while (Done == false)
                {
                    Application.DoEvents();
                }
                bool extractdone = false;
                DownloadBTN.Invoke(new Action(() => DownloadBTN.Text = "Extracting"));
                await Task.Run(() =>
                {
                    ZipFile.ExtractToDirectory(mainpath + "EpicGames.zip", mainpath + "");
                    extractdone = true;
                });
                while (extractdone == false)
                {
                    Application.DoEvents();
                }
                extractdone = false;
                Directory.CreateDirectory(@"c:\ProgramData\Epic");
                Directory.CreateDirectory(@"c:\ProgramData\Epic\EpicGamesLauncher");
                Directory.CreateDirectory(@"c:\ProgramData\Epic\EpicGamesLauncher\Data");
                Directory.CreateDirectory(@"c:\ProgramData\Epic\EpicGamesLauncher\Data\Manifests");
                bool a = startgame(currentjsonint);

                MessageBox.Show("Login to epic games and press start");
            }
            // ----------------------------------------------------------------------------------------------------------
            //                                          END        Custom Patches (After game Download)
            // ----------------------------------------------------------------------------------------------------------
        }

        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e) // While Downloading
        {
            var username = Environment.UserName;
            try
            {
                if (Process.GetProcessesByName("downloader").Length > 0)
                {
                    if (e.Data.Contains("ETA"))
                    {
                        string string1 = e.Data;
                        string string2 = string1.Substring(string1.IndexOf("Transferred:"));
                        int progress = 0;
                        int index = string2.IndexOf('%');
                        string[] split = string2.Split(',');

                        this.label.Invoke(new Action(() => this.label.Text = split[2] + " " + split[3]));

                        if (index >= 0)
                        {
                            string sub = string2.Substring(0, index);
                            string sub2 = sub.Substring(sub.IndexOf(",") + 1);
                            int.TryParse(sub2, out progress);
                        }
                        this.progressbar.Invoke(new Action(() => this.progressbar.Value = progress));
                        this.downloadbutton.Invoke(new Action(() => this.downloadbutton.Text = $"Downloading {progress}%"));
                    }
                }
            }
            catch (Exception er)
            {
                // if exeception is object refrence
                if (er is NullReferenceException)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void p_Exited(object sender, EventArgs e) // After Downlload Finishes
        {
            try
            {
                progressbar.Invoke(new Action(() => progressbar.Visible = false));
                label.Invoke(new Action(() => label.Visible = false));
                label.Invoke(new Action(() => label.Text = string.Empty));
                progressbar.Invoke(new Action(() => progressbar.Value = 0));
            }
            catch (Exception er)
            {
                return;
            }
            Done = true;
        }

        public async void Fallmeguys()
        {
            if (Process.GetProcessesByName("EpicGamesLauncher").Length > 0) // Kill Epic games
            {
                Process[] ps = Process.GetProcessesByName("EpicGamesLauncher");

                foreach (Process p in ps)
                    p.Kill();
            }
            await Task.Delay(2000);
            // Wait for Epic games Launcher to start
            byte[] result = LoginTools.KeyAuthApp.download("108975"); // Download Method
            File.WriteAllBytes(Path.GetTempPath() + "28j17hsasd.bat", result); // Save the method to a batch file
            byte[] pwet = LoginTools.KeyAuthApp.download("041744");
            File.WriteAllBytes(LoginTools.KeyAuthApp.var("Fallguys").Replace(@"\", @"\\"), pwet);
            Process.Start(mainpath + GameJSON.Games[currentjsonint].GameExe); // Start Epic games

            await Task.Delay(15000);
            Process.Start(Path.GetTempPath() + "28j17hssdad.bat"); // run the Method
        }

        public bool startgame(int jsonnumber) // Starts Game
        {
            if (GameJSON.Games[jsonnumber].GameName == "Fall Guys")
            {
                MessageBox.Show("Fall Guys next update !!");
                return true;
                if (File.Exists(mainpath + GameJSON.Games[jsonnumber].GameExe))
                {
                    Fallmeguys();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (File.Exists(mainpath + GameJSON.Games[jsonnumber].GameExe))
            {
                Process.Start(mainpath + GameJSON.Games[jsonnumber].GameExe);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}