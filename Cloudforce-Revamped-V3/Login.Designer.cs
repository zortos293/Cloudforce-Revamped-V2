namespace Cloudforce_Revamped_V3
{
    partial class Login
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TopBarpanel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2ControlBox();
            this.UserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UsernameLBL = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassLBL = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ErrorLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.RememberSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TopBarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarpanel
            // 
            this.TopBarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            this.TopBarpanel.Controls.Add(this.guna2HtmlLabel3);
            this.TopBarpanel.Controls.Add(this.CloseBTN);
            this.TopBarpanel.Controls.Add(this.UserImage);
            this.guna2Transition1.SetDecoration(this.TopBarpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopBarpanel.Location = new System.Drawing.Point(0, -1);
            this.TopBarpanel.Name = "TopBarpanel";
            this.TopBarpanel.Size = new System.Drawing.Size(800, 48);
            this.TopBarpanel.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 15);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(111, 19);
            this.guna2HtmlLabel3.TabIndex = 13;
            this.guna2HtmlLabel3.Text = "CloudForce Login";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBTN.BackColor = System.Drawing.Color.Transparent;
            this.CloseBTN.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.CloseBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.CloseBTN.IconColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(770, 3);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.ShadowDecoration.Enabled = true;
            this.CloseBTN.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CloseBTN.Size = new System.Drawing.Size(27, 23);
            this.CloseBTN.TabIndex = 5;
            // 
            // UserImage
            // 
            this.guna2Transition1.SetDecoration(this.UserImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UserImage.ImageRotate = 0F;
            this.UserImage.Location = new System.Drawing.Point(907, 7);
            this.UserImage.Name = "UserImage";
            this.UserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserImage.Size = new System.Drawing.Size(37, 35);
            this.UserImage.TabIndex = 0;
            this.UserImage.TabStop = false;
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.BorderColor = System.Drawing.Color.Gray;
            this.UsernameLBL.BorderRadius = 6;
            this.UsernameLBL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.UsernameLBL, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UsernameLBL.DefaultText = "";
            this.UsernameLBL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameLBL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameLBL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameLBL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameLBL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.UsernameLBL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameLBL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameLBL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameLBL.Location = new System.Drawing.Point(276, 140);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.PasswordChar = '\0';
            this.UsernameLBL.PlaceholderText = "";
            this.UsernameLBL.SelectedText = "";
            this.UsernameLBL.Size = new System.Drawing.Size(255, 36);
            this.UsernameLBL.TabIndex = 2;
            // 
            // PassLBL
            // 
            this.PassLBL.BorderColor = System.Drawing.Color.Gray;
            this.PassLBL.BorderRadius = 6;
            this.PassLBL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.PassLBL, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PassLBL.DefaultText = "";
            this.PassLBL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassLBL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassLBL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassLBL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassLBL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.PassLBL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassLBL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PassLBL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassLBL.Location = new System.Drawing.Point(276, 206);
            this.PassLBL.Name = "PassLBL";
            this.PassLBL.PasswordChar = '*';
            this.PassLBL.PlaceholderText = "";
            this.PassLBL.SelectedText = "";
            this.PassLBL.Size = new System.Drawing.Size(255, 36);
            this.PassLBL.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(276, 182);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(61, 19);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Password";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(276, 115);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 19);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "Username";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Cloudforce_Revamped_V3.Properties.Resources.account_96px;
            this.guna2Button1.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button1.Location = new System.Drawing.Point(276, 325);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(255, 37);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Sign in as Guest";
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Cloudforce_Revamped_V3.Properties.Resources.login_96px;
            this.guna2Button2.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button2.Location = new System.Drawing.Point(276, 282);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(255, 37);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Login";
            this.guna2Button2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ErrorLBL
            // 
            this.ErrorLBL.AutoSize = false;
            this.ErrorLBL.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.ErrorLBL, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ErrorLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLBL.ForeColor = System.Drawing.Color.Red;
            this.ErrorLBL.Location = new System.Drawing.Point(276, 76);
            this.ErrorLBL.Name = "ErrorLBL";
            this.ErrorLBL.Size = new System.Drawing.Size(255, 19);
            this.ErrorLBL.TabIndex = 13;
            this.ErrorLBL.Text = null;
            this.ErrorLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.TopBarpanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 1000;
            // 
            // RememberSwitch
            // 
            this.RememberSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.RememberSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RememberSwitch.Location = new System.Drawing.Point(277, 253);
            this.RememberSwitch.Name = "RememberSwitch";
            this.RememberSwitch.Size = new System.Drawing.Size(35, 20);
            this.RememberSwitch.TabIndex = 14;
            this.RememberSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(318, 254);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(92, 19);
            this.guna2HtmlLabel4.TabIndex = 15;
            this.guna2HtmlLabel4.Text = "Remember Me";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.RememberSwitch);
            this.Controls.Add(this.ErrorLBL);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.PassLBL);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.TopBarpanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudForce Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.TopBarpanel.ResumeLayout(false);
            this.TopBarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBarpanel;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBTN;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserImage;
        private Guna.UI2.WinForms.Guna2TextBox UsernameLBL;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox PassLBL;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ErrorLBL;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RememberSwitch;
    }
}