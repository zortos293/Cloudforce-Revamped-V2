using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Newtonsoft.Json;
using static Cloudforce_Revamped_V3.AppsJSON;
using System.IO;
using Cloudforce_Revamped_V3.Properties;

namespace Cloudforce_Revamped_V3
{
    internal class DynamicLoader
    {
        List<string> BTNNames = new List<string>();
        Root APPJson = JsonConvert.DeserializeObject<AppsJSON.Root>(File.ReadAllText("C:\\Users\\Zortos\\Documents\\Cloudforce-Revamped-Resources\\Apps.json"));
        public static string mainpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\";

        public void LoadAppButtons(FlowLayoutPanel FlowPanel,Form1 form)
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

                button.CustomImages.Image = Resources.downloading_updates_500px;
                button.CustomImages.ImageAlign = HorizontalAlignment.Right;
                button.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
                button.CustomImages.ImageSize = new System.Drawing.Size(20, 20);
                BTNNames.Add(button.Name);
                button.Size = new System.Drawing.Size(205, 40);
                button.BorderRadius = 6;
                button.ImageAlign = HorizontalAlignment.Left;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(APPJson.Apps[i].AppImage);
                MemoryStream ms = new MemoryStream(bytes);
                form.AllappsLBL.Text = $"All Apps [{APPJson.Apps.Count()}]";
                button.Image = System.Drawing.Image.FromStream(ms); // Button Image
                button.TabIndex = 0;
                button.TextAlign = HorizontalAlignment.Left;
                button.Text = APPJson.Apps[i].AppName; 
                button.Click += (s, e) => {
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
                            ctl.CustomImages.Image = Resources.downloading_updates_500px; ;
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
        }

        public void ClearButtons(FlowLayoutPanel FlowPanel)
        {
            foreach (Guna2Button ctl in FlowPanel.Controls.OfType<Guna2Button>())
            {
                ctl.FillColor = System.Drawing.Color.Transparent;
            }
        }


    }
}
