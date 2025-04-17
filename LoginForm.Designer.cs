namespace ExamQuiz
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.drag_panel = new System.Windows.Forms.Panel();
            this.hide_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.choice_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.registration_button = new Guna.UI2.WinForms.Guna2Button();
            this.action_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.login_page = new ExamQuiz.UC_LoginPage();
            this.registration_page = new ExamQuiz.UC_RegistrationPage();
            this.drag_panel.SuspendLayout();
            this.choice_panel.SuspendLayout();
            this.action_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.drag_panel.Controls.Add(this.hide_button);
            this.drag_panel.Controls.Add(this.close_button);
            this.drag_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drag_panel.Location = new System.Drawing.Point(0, 0);
            this.drag_panel.Margin = new System.Windows.Forms.Padding(0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(850, 34);
            this.drag_panel.TabIndex = 2;
            // 
            // hide_button
            // 
            this.hide_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide_button.Animated = true;
            this.hide_button.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.hide_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.hide_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hide_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.hide_button.Location = new System.Drawing.Point(730, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(60, 31);
            this.hide_button.TabIndex = 1;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Animated = true;
            this.close_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.close_button.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.close_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.close_button.Location = new System.Drawing.Point(790, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(60, 31);
            this.close_button.TabIndex = 0;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.drag_panel;
            this.dragControl.UseTransparentDrag = true;
            // 
            // choice_panel
            // 
            this.choice_panel.AutoRoundedCorners = true;
            this.choice_panel.BackColor = System.Drawing.Color.Transparent;
            this.choice_panel.Controls.Add(this.login_button);
            this.choice_panel.Controls.Add(this.registration_button);
            this.choice_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.choice_panel.Location = new System.Drawing.Point(220, 70);
            this.choice_panel.Name = "choice_panel";
            this.choice_panel.ShadowDecoration.BorderRadius = 35;
            this.choice_panel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.choice_panel.ShadowDecoration.Enabled = true;
            this.choice_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(15);
            this.choice_panel.Size = new System.Drawing.Size(410, 64);
            this.choice_panel.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.login_button.BorderColor = System.Drawing.Color.Empty;
            this.login_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.login_button.Checked = true;
            this.login_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(100)))), ((int)(((byte)(217)))));
            this.login_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.login_button.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.login_button.Location = new System.Drawing.Point(0, 0);
            this.login_button.Margin = new System.Windows.Forms.Padding(0);
            this.login_button.Name = "login_button";
            this.login_button.PressedColor = System.Drawing.Color.White;
            this.login_button.Size = new System.Drawing.Size(200, 64);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // registration_button
            // 
            this.registration_button.Animated = true;
            this.registration_button.AutoRoundedCorners = true;
            this.registration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.registration_button.BorderColor = System.Drawing.Color.Empty;
            this.registration_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.registration_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(100)))), ((int)(((byte)(217)))));
            this.registration_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registration_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registration_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registration_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registration_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.registration_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.registration_button.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.registration_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.registration_button.Location = new System.Drawing.Point(210, 0);
            this.registration_button.Margin = new System.Windows.Forms.Padding(0);
            this.registration_button.Name = "registration_button";
            this.registration_button.PressedColor = System.Drawing.Color.White;
            this.registration_button.Size = new System.Drawing.Size(200, 64);
            this.registration_button.TabIndex = 4;
            this.registration_button.Text = "Registration";
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // action_panel
            // 
            this.action_panel.Controls.Add(this.login_page);
            this.action_panel.Controls.Add(this.registration_page);
            this.action_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_panel.Location = new System.Drawing.Point(0, 162);
            this.action_panel.Margin = new System.Windows.Forms.Padding(0);
            this.action_panel.Name = "action_panel";
            this.action_panel.Size = new System.Drawing.Size(850, 393);
            this.action_panel.TabIndex = 4;
            // 
            // login_page
            // 
            this.login_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_page.Location = new System.Drawing.Point(0, 0);
            this.login_page.Name = "login_page";
            this.login_page.Size = new System.Drawing.Size(850, 393);
            this.login_page.TabIndex = 1;
            // 
            // registration_page
            // 
            this.registration_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registration_page.Location = new System.Drawing.Point(0, 0);
            this.registration_page.Name = "registration_page";
            this.registration_page.Size = new System.Drawing.Size(850, 393);
            this.registration_page.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(850, 555);
            this.Controls.Add(this.action_panel);
            this.Controls.Add(this.choice_panel);
            this.Controls.Add(this.drag_panel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chill Quiz | Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.drag_panel.ResumeLayout(false);
            this.choice_panel.ResumeLayout(false);
            this.action_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drag_panel;
        private Guna.UI2.WinForms.Guna2ControlBox hide_button;
        private Guna.UI2.WinForms.Guna2ControlBox close_button;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel choice_panel;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button registration_button;
        private Guna.UI2.WinForms.Guna2Panel action_panel;
        private UC_RegistrationPage registration_page;
        private UC_LoginPage login_page;
    }
}