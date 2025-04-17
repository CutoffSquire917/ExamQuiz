using System;

namespace ExamQuiz
{
    partial class UC_RegistrationPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.registration_button = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.passwordError_indicator = new Guna.UI2.WinForms.Guna2Panel();
            this.loginError_indicator = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Animated = true;
            this.login_textBox.BorderColor = System.Drawing.Color.Silver;
            this.login_textBox.BorderRadius = 20;
            this.login_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_textBox.DefaultText = "";
            this.login_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.login_textBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_textBox.Location = new System.Drawing.Point(341, 51);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.login_textBox.MaxLength = 20;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.login_textBox.PlaceholderText = "";
            this.login_textBox.SelectedText = "";
            this.login_textBox.Size = new System.Drawing.Size(460, 47);
            this.login_textBox.TabIndex = 7;
            this.login_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.login_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = false;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_label.Location = new System.Drawing.Point(341, 10);
            this.login_label.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(321, 41);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "Nickname";
            this.login_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_textBox
            // 
            this.password_textBox.Animated = true;
            this.password_textBox.BorderColor = System.Drawing.Color.Silver;
            this.password_textBox.BorderRadius = 20;
            this.password_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textBox.DefaultText = "";
            this.password_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.password_textBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.password_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password_textBox.Location = new System.Drawing.Point(341, 159);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.password_textBox.MaxLength = 20;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '●';
            this.password_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.password_textBox.PlaceholderText = "";
            this.password_textBox.SelectedText = "";
            this.password_textBox.Size = new System.Drawing.Size(460, 47);
            this.password_textBox.TabIndex = 9;
            this.password_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.password_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = false;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.password_label.Location = new System.Drawing.Point(341, 118);
            this.password_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(321, 41);
            this.password_label.TabIndex = 10;
            this.password_label.Text = "Password";
            this.password_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registration_button
            // 
            this.registration_button.Animated = true;
            this.registration_button.AutoRoundedCorners = true;
            this.registration_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.registration_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registration_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registration_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registration_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registration_button.FillColor = System.Drawing.Color.Silver;
            this.registration_button.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_button.ForeColor = System.Drawing.Color.White;
            this.registration_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.registration_button.Location = new System.Drawing.Point(341, 311);
            this.registration_button.Margin = new System.Windows.Forms.Padding(0, 0, 50, 30);
            this.registration_button.Name = "registration_button";
            this.registration_button.PressedColor = System.Drawing.Color.GhostWhite;
            this.registration_button.Size = new System.Drawing.Size(459, 52);
            this.registration_button.TabIndex = 11;
            this.registration_button.Text = "Registration";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Animated = true;
            this.dateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.dateTimePicker.BorderRadius = 20;
            this.dateTimePicker.BorderThickness = 1;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.dateTimePicker.CheckedState.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.dateTimePicker.Location = new System.Drawing.Point(340, 231);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(461, 50);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.TextOffset = new System.Drawing.Point(15, 0);
            this.dateTimePicker.Value = new System.DateTime(2025, 4, 16, 0, 0, 0, 0);
            // 
            // passwordError_indicator
            // 
            this.passwordError_indicator.AutoRoundedCorners = true;
            this.passwordError_indicator.BackColor = System.Drawing.Color.Transparent;
            this.passwordError_indicator.BorderRadius = 2;
            this.passwordError_indicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.passwordError_indicator.Location = new System.Drawing.Point(544, 209);
            this.passwordError_indicator.Name = "passwordError_indicator";
            this.passwordError_indicator.Size = new System.Drawing.Size(50, 7);
            this.passwordError_indicator.TabIndex = 15;
            this.passwordError_indicator.Visible = false;
            // 
            // loginError_indicator
            // 
            this.loginError_indicator.AutoRoundedCorners = true;
            this.loginError_indicator.BackColor = System.Drawing.Color.Transparent;
            this.loginError_indicator.BorderRadius = 2;
            this.loginError_indicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginError_indicator.Location = new System.Drawing.Point(544, 101);
            this.loginError_indicator.Name = "loginError_indicator";
            this.loginError_indicator.Size = new System.Drawing.Size(50, 7);
            this.loginError_indicator.TabIndex = 16;
            this.loginError_indicator.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ExamQuiz.Properties.Resources.imageForLogin;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-280, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(560, 368);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.loginError_indicator);
            this.Controls.Add(this.passwordError_indicator);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_textBox);
            this.Name = "UC_RegistrationPage";
            this.Size = new System.Drawing.Size(850, 393);
            this.Load += new System.EventHandler(this.UC_RegistrationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private Guna.UI2.WinForms.Guna2TextBox login_textBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel login_label;
        private Guna.UI2.WinForms.Guna2TextBox password_textBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel password_label;
        private Guna.UI2.WinForms.Guna2Button registration_button;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        public Action UserRegisteredHandler;
        private Guna.UI2.WinForms.Guna2Panel passwordError_indicator;
        private Guna.UI2.WinForms.Guna2Panel loginError_indicator;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
