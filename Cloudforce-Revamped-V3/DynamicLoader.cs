using Cloudforce_Revamped_V3.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static Cloudforce_Revamped_V3.AppsJSON;
using static Cloudforce_Revamped_V3.GamesJSON;

namespace Cloudforce_Revamped_V3
{
    internal class DynamicLoader
    {
        private List<string> BTNNames = new List<string>();

        public static string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\";

        public void LoadAppButtons(FlowLayoutPanel FlowPanel, Form1 form)
        {
            for (int i = 0; i < APPJson.Apps.Count(); i++) // json Count
            {
                Guna2Button button = new Guna2Button();
                button.Tag = i;
                button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                button.FillColor = System.Drawing.Color.Transparent;
                button.Font = new System.Drawing.Font("Segoe UI", 9F);
                button.ForeColor = System.Drawing.Color.Gray;
                button.Name = APPJson.Apps[i].AppName + "BTN";

                button.CustomImages.Image = Resources.downloading_updates_96px;
                button.CustomImages.ImageAlign = HorizontalAlignment.Right;
                button.CustomImages.ImageOffset = new System.Drawing.Point(2, 0);
                button.CustomImages.ImageSize = new System.Drawing.Size(20, 20);
                BTNNames.Add(button.Name);
                button.Size = new System.Drawing.Size(190, 40);
                button.BorderRadius = 6;
                button.ImageAlign = HorizontalAlignment.Left;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(APPJson.Apps[i].AppImage);
                MemoryStream ms = new MemoryStream(bytes);
                button.Image = System.Drawing.Image.FromStream(ms); // Button Image
                button.TabIndex = 0;
                button.TextAlign = HorizontalAlignment.Left;
                button.Text = APPJson.Apps[i].AppName;
                button.Click += (s, e) =>
                {
                    ClearButtons(FlowPanel);
                    foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
                    {
                        var tag = ctl.Tag.ToString();
                        if (File.Exists(mainpath + APPJson.Apps[int.Parse(tag)].AppExe))
                        {
                            ctl.ForeColor = System.Drawing.Color.White;
                            ctl.CustomImages.Image = null;
                        }
                        else
                        {
                            ctl.ForeColor = System.Drawing.Color.Gray;
                            ctl.CustomImages.Image = Resources.downloading_updates_96px; ;
                        }
                    }
                    button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
                    form.AppsInfo(int.Parse(button.Tag.ToString()));
                };
                FlowPanel.Controls.Add(button);
            }
            foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
            {
                var tag = ctl.Tag.ToString();
                if (File.Exists(mainpath + APPJson.Apps[int.Parse(tag)].AppExe))
                {
                    ctl.ForeColor = System.Drawing.Color.White;
                    ctl.CustomImages.Image = null;
                }
            }
            form.AllappsLBL.Text = $"All Apps [{APPJson.Apps.Count()}]";
        }

        public void ClearButtons(FlowLayoutPanel FlowPanel)
        {
            foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
            {
                ctl.FillColor = System.Drawing.Color.Transparent;
            }
        }

        public void LoadGameButtons(FlowLayoutPanel FlowPanel, Form1 form)
        {
            for (int i = 0; i < GameJSON.Games.Count(); i++) // json Count
            {
                Guna2Button button = new Guna2Button();
                button.Tag = i;
                button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                button.FillColor = System.Drawing.Color.Transparent;
                button.Font = new System.Drawing.Font("Segoe UI", 9F);
                button.ForeColor = System.Drawing.Color.Gray;
                button.Name = GameJSON.Games[i].GameName + "BTN";

                button.CustomImages.Image = Resources.downloading_updates_96px;
                button.CustomImages.ImageAlign = HorizontalAlignment.Right;
                button.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
                button.CustomImages.ImageSize = new System.Drawing.Size(20, 20);
                BTNNames.Add(button.Name);
                button.Size = new System.Drawing.Size(190, 40);
                button.BorderRadius = 6;
                button.ImageAlign = HorizontalAlignment.Left;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(GameJSON.Games[i].GameIcon);
                MemoryStream ms = new MemoryStream(bytes);
                button.Image = System.Drawing.Image.FromStream(ms); // Button Image
                button.TabIndex = 0;
                button.TextAlign = HorizontalAlignment.Left;
                button.Text = GameJSON.Games[i].GameName;
                button.Click += (s, e) =>
                {
                    ClearButtons(FlowPanel);
                    foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
                    {
                        var tag = ctl.Tag.ToString();
                        if (File.Exists(mainpath + GameJSON.Games[int.Parse(tag)].GameExe))
                        {
                            ctl.ForeColor = System.Drawing.Color.White;
                            ctl.CustomImages.Image = null;
                        }
                        else
                        {
                            ctl.ForeColor = System.Drawing.Color.Gray;
                            ctl.CustomImages.Image = Resources.downloading_updates_96px; ;
                        }
                    }
                    button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
                    form.GameInfos(int.Parse(button.Tag.ToString()));
                };
                FlowPanel.Controls.Add(button);
            }
            foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
            {
                var tag = ctl.Tag.ToString();
                if (File.Exists(mainpath + GameJSON.Games[int.Parse(tag)].GameExe))
                {
                    ctl.ForeColor = System.Drawing.Color.White;
                    ctl.CustomImages.Image = null;
                }
            }
            form.AllGamesLBL.Text = $"All Games [{GameJSON.Games.Count()}]";
        }
    }
}