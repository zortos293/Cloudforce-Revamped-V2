namespace Cloudforce_Revamped_V3
{
    partial class Form1
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
            this.TopBarpanel = new System.Windows.Forms.Panel();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GamesBTN = new Guna.UI2.WinForms.Guna2Button();
            this.AppsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.UsernameLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FullFormRound = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormTabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AppsInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.allappsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AllappsLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AppsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FlowLayoutPanelApps = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.All_Apps_Panel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TopBarpanel.SuspendLayout();
            this.FormTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.allappsPanel.SuspendLayout();
            this.AppsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarpanel
            // 
            this.TopBarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            this.TopBarpanel.Controls.Add(this.CloseBTN);
            this.TopBarpanel.Controls.Add(this.GamesBTN);
            this.TopBarpanel.Controls.Add(this.AppsBTN);
            this.TopBarpanel.Controls.Add(this.HomeBTN);
            this.TopBarpanel.Controls.Add(this.UsernameLBL);
            this.TopBarpanel.Controls.Add(this.UserImage);
            this.TopBarpanel.Location = new System.Drawing.Point(-1, -1);
            this.TopBarpanel.Name = "TopBarpanel";
            this.TopBarpanel.Size = new System.Drawing.Size(985, 48);
            this.TopBarpanel.TabIndex = 0;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBTN.BackColor = System.Drawing.Color.Transparent;
            this.CloseBTN.BorderRadius = 6;
            this.CloseBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.CloseBTN.IconColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(955, 3);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.ShadowDecoration.Enabled = true;
            this.CloseBTN.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CloseBTN.Size = new System.Drawing.Size(27, 23);
            this.CloseBTN.TabIndex = 5;
            // 
            // GamesBTN
            // 
            this.GamesBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GamesBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GamesBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GamesBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GamesBTN.FillColor = System.Drawing.Color.Transparent;
            this.GamesBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GamesBTN.ForeColor = System.Drawing.Color.Silver;
            this.GamesBTN.Location = new System.Drawing.Point(217, 6);
            this.GamesBTN.Name = "GamesBTN";
            this.GamesBTN.Size = new System.Drawing.Size(96, 38);
            this.GamesBTN.TabIndex = 4;
            this.GamesBTN.Text = "Games";
            this.GamesBTN.Click += new System.EventHandler(this.Appsbutton_Click);
            // 
            // AppsBTN
            // 
            this.AppsBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppsBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppsBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppsBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppsBTN.FillColor = System.Drawing.Color.Transparent;
            this.AppsBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppsBTN.ForeColor = System.Drawing.Color.Silver;
            this.AppsBTN.Location = new System.Drawing.Point(115, 6);
            this.AppsBTN.Name = "AppsBTN";
            this.AppsBTN.Size = new System.Drawing.Size(96, 38);
            this.AppsBTN.TabIndex = 3;
            this.AppsBTN.Text = "Apps";
            this.AppsBTN.Click += new System.EventHandler(this.Appsbutton_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBTN.FillColor = System.Drawing.Color.Transparent;
            this.HomeBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HomeBTN.ForeColor = System.Drawing.Color.Silver;
            this.HomeBTN.Location = new System.Drawing.Point(13, 6);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(96, 38);
            this.HomeBTN.TabIndex = 2;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.Click += new System.EventHandler(this.Appsbutton_Click);
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UsernameLBL.AutoSize = false;
            this.UsernameLBL.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLBL.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLBL.Location = new System.Drawing.Point(783, 16);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(114, 18);
            this.UsernameLBL.TabIndex = 1;
            this.UsernameLBL.Text = "Please Log In";
            this.UsernameLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullFormRound
            // 
            this.FullFormRound.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.TopBarpanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormTabs
            // 
            this.FormTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.FormTabs.Controls.Add(this.tabPage1);
            this.FormTabs.Controls.Add(this.tabPage2);
            this.FormTabs.Controls.Add(this.tabPage3);
            this.FormTabs.Controls.Add(this.tabPage4);
            this.FormTabs.ItemSize = new System.Drawing.Size(180, 40);
            this.FormTabs.Location = new System.Drawing.Point(-3, 47);
            this.FormTabs.Name = "FormTabs";
            this.FormTabs.SelectedIndex = 0;
            this.FormTabs.Size = new System.Drawing.Size(987, 526);
            this.FormTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.FormTabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.FormTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.FormTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.FormTabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.FormTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.FormTabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.FormTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.FormTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.FormTabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.FormTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.FormTabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.FormTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.FormTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.FormTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.FormTabs.TabButtonSize = new System.Drawing.Size(180, 40);
            this.FormTabs.TabIndex = 2;
            this.FormTabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.FormTabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tabPage1.Controls.Add(this.guna2HtmlLabel2);
            this.tabPage1.Controls.Add(this.guna2HtmlLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(361, 56);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(277, 21);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Welcome To Cloudforce-revamped !";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 455);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(59, 19);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "V3.0 DEV";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tabPage2.Controls.Add(this.AppsInfoPanel);
            this.tabPage2.Controls.Add(this.allappsPanel);
            this.tabPage2.Controls.Add(this.AppsPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // AppsInfoPanel
            // 
            this.AppsInfoPanel.Location = new System.Drawing.Point(213, 7);
            this.AppsInfoPanel.Name = "AppsInfoPanel";
            this.AppsInfoPanel.Size = new System.Drawing.Size(757, 465);
            this.AppsInfoPanel.TabIndex = 4;
            // 
            // allappsPanel
            // 
            this.allappsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.allappsPanel.Controls.Add(this.AllappsLBL);
            this.allappsPanel.Location = new System.Drawing.Point(3, 2);
            this.allappsPanel.Name = "allappsPanel";
            this.allappsPanel.Size = new System.Drawing.Size(199, 21);
            this.allappsPanel.TabIndex = 3;
            // 
            // AllappsLBL
            // 
            this.AllappsLBL.BackColor = System.Drawing.Color.Transparent;
            this.AllappsLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllappsLBL.ForeColor = System.Drawing.Color.White;
            this.AllappsLBL.Location = new System.Drawing.Point(3, 1);
            this.AllappsLBL.Name = "AllappsLBL";
            this.AllappsLBL.Size = new System.Drawing.Size(55, 19);
            this.AllappsLBL.TabIndex = 1;
            this.AllappsLBL.Text = "All Apps";
            // 
            // AppsPanel
            // 
            this.AppsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.AppsPanel.Controls.Add(this.flowLayoutPanel1);
            this.AppsPanel.CustomizableEdges.BottomLeft = false;
            this.AppsPanel.CustomizableEdges.BottomRight = false;
            this.AppsPanel.Location = new System.Drawing.Point(0, 37);
            this.AppsPanel.Name = "AppsPanel";
            this.AppsPanel.Size = new System.Drawing.Size(202, 441);
            this.AppsPanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 441);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(979, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(979, 478);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanelApps
            // 
            this.FlowLayoutPanelApps.TargetControl = this.AppsPanel;
            // 
            // All_Apps_Panel
            // 
            this.All_Apps_Panel.BorderRadius = 4;
            this.All_Apps_Panel.TargetControl = this.allappsPanel;
            // 
            // UserImage
            // 
            this.UserImage.ImageRotate = 0F;
            this.UserImage.Location = new System.Drawing.Point(907, 7);
            this.UserImage.Name = "UserImage";
            this.UserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserImage.Size = new System.Drawing.Size(37, 35);
            this.UserImage.TabIndex = 0;
            this.UserImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 536);
            this.Controls.Add(this.FormTabs);
            this.Controls.Add(this.TopBarpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopBarpanel.ResumeLayout(false);
            this.FormTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.allappsPanel.ResumeLayout(false);
            this.allappsPanel.PerformLayout();
            this.AppsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarpanel;
        private Guna.UI2.WinForms.Guna2Button GamesBTN;
        private Guna.UI2.WinForms.Guna2Button AppsBTN;
        private Guna.UI2.WinForms.Guna2Button HomeBTN;
        private Guna.UI2.WinForms.Guna2HtmlLabel UsernameLBL;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserImage;
        private Guna.UI2.WinForms.Guna2Elipse FullFormRound;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBTN;
        private Guna.UI2.WinForms.Guna2TabControl FormTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel AppsPanel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Elipse FlowLayoutPanelApps;
        private Guna.UI2.WinForms.Guna2Panel allappsPanel;
        private Guna.UI2.WinForms.Guna2Elipse All_Apps_Panel;
        private Guna.UI2.WinForms.Guna2Panel AppsInfoPanel;
        public Guna.UI2.WinForms.Guna2HtmlLabel AllappsLBL;
    }
}

