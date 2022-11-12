namespace Cloudforce_Revamped_V3
{
    partial class AppInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfo));
            this.AppNameLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.GFNStatusLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.AppDescriptionLBL = new System.Windows.Forms.RichTextBox();
            this.GFNIssuesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.GFNIssuesLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Progressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.DownloadBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AppImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AppUpdateLBL = new System.Windows.Forms.RichTextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.GFNIssuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AppNameLBL
            // 
            this.AppNameLBL.BackColor = System.Drawing.Color.Transparent;
            this.AppNameLBL.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLBL.ForeColor = System.Drawing.Color.White;
            this.AppNameLBL.Location = new System.Drawing.Point(189, 21);
            this.AppNameLBL.Name = "AppNameLBL";
            this.AppNameLBL.Size = new System.Drawing.Size(106, 30);
            this.AppNameLBL.TabIndex = 2;
            this.AppNameLBL.Text = "Appname";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.GFNIssuesPanel;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.guna2Panel2.Controls.Add(this.GFNStatusLBL);
            this.guna2Panel2.Location = new System.Drawing.Point(13, 415);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(151, 38);
            this.guna2Panel2.TabIndex = 6;
            // 
            // GFNStatusLBL
            // 
            this.GFNStatusLBL.BackColor = System.Drawing.Color.Transparent;
            this.GFNStatusLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GFNStatusLBL.ForeColor = System.Drawing.Color.White;
            this.GFNStatusLBL.Location = new System.Drawing.Point(7, 8);
            this.GFNStatusLBL.Name = "GFNStatusLBL";
            this.GFNStatusLBL.Size = new System.Drawing.Size(83, 21);
            this.GFNStatusLBL.TabIndex = 0;
            this.GFNStatusLBL.Text = "GFN Status :";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.guna2Panel3.Controls.Add(this.AppDescriptionLBL);
            this.guna2Panel3.Location = new System.Drawing.Point(13, 205);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(455, 155);
            this.guna2Panel3.TabIndex = 7;
            // 
            // AppDescriptionLBL
            // 
            this.AppDescriptionLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.AppDescriptionLBL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppDescriptionLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDescriptionLBL.ForeColor = System.Drawing.Color.White;
            this.AppDescriptionLBL.Location = new System.Drawing.Point(7, 4);
            this.AppDescriptionLBL.Name = "AppDescriptionLBL";
            this.AppDescriptionLBL.Size = new System.Drawing.Size(445, 148);
            this.AppDescriptionLBL.TabIndex = 0;
            this.AppDescriptionLBL.Text = "";
            // 
            // GFNIssuesPanel
            // 
            this.GFNIssuesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.GFNIssuesPanel.Controls.Add(this.GFNIssuesLBL);
            this.GFNIssuesPanel.Location = new System.Drawing.Point(179, 415);
            this.GFNIssuesPanel.Name = "GFNIssuesPanel";
            this.GFNIssuesPanel.Size = new System.Drawing.Size(455, 38);
            this.GFNIssuesPanel.TabIndex = 8;
            // 
            // GFNIssuesLBL
            // 
            this.GFNIssuesLBL.AutoSize = false;
            this.GFNIssuesLBL.BackColor = System.Drawing.Color.Transparent;
            this.GFNIssuesLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GFNIssuesLBL.ForeColor = System.Drawing.Color.White;
            this.GFNIssuesLBL.Location = new System.Drawing.Point(6, 6);
            this.GFNIssuesLBL.Name = "GFNIssuesLBL";
            this.GFNIssuesLBL.Size = new System.Drawing.Size(445, 29);
            this.GFNIssuesLBL.TabIndex = 0;
            this.GFNIssuesLBL.Text = "GFN Issues : ";
            this.GFNIssuesLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Progressbar
            // 
            this.Progressbar.BorderRadius = 6;
            this.Progressbar.Location = new System.Drawing.Point(189, 101);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(180, 14);
            this.Progressbar.TabIndex = 9;
            this.Progressbar.Text = "Progressbar";
            this.Progressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Progressbar.Visible = false;
            // 
            // DownloadBTN
            // 
            this.DownloadBTN.Animated = true;
            this.DownloadBTN.AnimatedGIF = true;
            this.DownloadBTN.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBTN.BorderRadius = 6;
            this.DownloadBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DownloadBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DownloadBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownloadBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownloadBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DownloadBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.DownloadBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DownloadBTN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBTN.ForeColor = System.Drawing.Color.White;
            this.DownloadBTN.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.DownloadBTN.Image = ((System.Drawing.Image)(resources.GetObject("DownloadBTN.Image")));
            this.DownloadBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DownloadBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DownloadBTN.Location = new System.Drawing.Point(189, 121);
            this.DownloadBTN.Name = "DownloadBTN";
            this.DownloadBTN.Size = new System.Drawing.Size(180, 45);
            this.DownloadBTN.TabIndex = 4;
            this.DownloadBTN.Text = "Download";
            this.DownloadBTN.UseTransparentBackground = true;
            this.DownloadBTN.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // AppImage
            // 
            this.AppImage.BorderRadius = 6;
            this.AppImage.FillColor = System.Drawing.Color.DarkGray;
            this.AppImage.ImageRotate = 0F;
            this.AppImage.Location = new System.Drawing.Point(13, 12);
            this.AppImage.Name = "AppImage";
            this.AppImage.Size = new System.Drawing.Size(163, 154);
            this.AppImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppImage.TabIndex = 10;
            this.AppImage.TabStop = false;
            // 
            // AppUpdateLBL
            // 
            this.AppUpdateLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.AppUpdateLBL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppUpdateLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppUpdateLBL.ForeColor = System.Drawing.Color.White;
            this.AppUpdateLBL.Location = new System.Drawing.Point(555, 21);
            this.AppUpdateLBL.Name = "AppUpdateLBL";
            this.AppUpdateLBL.Size = new System.Drawing.Size(190, 339);
            this.AppUpdateLBL.TabIndex = 1;
            this.AppUpdateLBL.Text = "";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.AppUpdateLBL;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.guna2Panel3;
            // 
            // AppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.AppUpdateLBL);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.GFNIssuesPanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.DownloadBTN);
            this.Controls.Add(this.AppImage);
            this.Controls.Add(this.AppNameLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppInfo";
            this.Text = "AppInfo";
            this.Load += new System.EventHandler(this.AppInfo_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.GFNIssuesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel AppNameLBL;
        private Guna.UI2.WinForms.Guna2PictureBox AppImage;
        private Guna.UI2.WinForms.Guna2GradientButton DownloadBTN;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel GFNStatusLBL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel GFNIssuesPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel GFNIssuesLBL;
        private System.Windows.Forms.RichTextBox AppDescriptionLBL;
        private Guna.UI2.WinForms.Guna2ProgressBar Progressbar;
        private System.Windows.Forms.RichTextBox AppUpdateLBL;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}