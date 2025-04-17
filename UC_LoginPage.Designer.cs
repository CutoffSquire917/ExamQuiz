using System;

namespace ExamQuiz
{
    partial class UC_LoginPage
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
            this.password_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.error_indicator = new Guna.UI2.WinForms.Guna2Button();
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
            this.login_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.login_textBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_textBox.Location = new System.Drawing.Point(50, 51);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.login_textBox.MaxLength = 20;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.login_textBox.PlaceholderText = "";
            this.login_textBox.SelectedText = "";
            this.login_textBox.Size = new System.Drawing.Size(460, 47);
            this.login_textBox.TabIndex = 0;
            this.login_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.login_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = false;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_label.Location = new System.Drawing.Point(50, 10);
            this.login_label.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(321, 41);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login";
            this.login_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_label
            // 
            this.password_label.AutoSize = false;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.password_label.Location = new System.Drawing.Point(50, 118);
            this.password_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(321, 41);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            this.password_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.password_textBox.Location = new System.Drawing.Point(50, 159);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.password_textBox.MaxLength = 20;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '●';
            this.password_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.password_textBox.PlaceholderText = "";
            this.password_textBox.SelectedText = "";
            this.password_textBox.Size = new System.Drawing.Size(460, 47);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.password_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.AutoRoundedCorners = true;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.Silver;
            this.login_button.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.login_button.Location = new System.Drawing.Point(51, 311);
            this.login_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.login_button.Name = "login_button";
            this.login_button.PressedColor = System.Drawing.Color.GhostWhite;
            this.login_button.Size = new System.Drawing.Size(459, 52);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            // 
            // error_indicator
            // 
            this.error_indicator.Animated = true;
            this.error_indicator.AutoRoundedCorners = true;
            this.error_indicator.BackColor = System.Drawing.Color.Transparent;
            this.error_indicator.FillColor = System.Drawing.SystemColors.Control;
            this.error_indicator.FocusedColor = System.Drawing.SystemColors.Control;
            this.error_indicator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.error_indicator.ForeColor = System.Drawing.Color.White;
            this.error_indicator.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.error_indicator.Location = new System.Drawing.Point(255, 209);
            this.error_indicator.Name = "error_indicator";
            this.error_indicator.PressedColor = System.Drawing.Color.Transparent;
            this.error_indicator.Size = new System.Drawing.Size(50, 7);
            this.error_indicator.TabIndex = 6;
            this.error_indicator.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ExamQuiz.Properties.Resources.imageForLogin;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(570, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(560, 368);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.error_indicator);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_textBox);
            this.Name = "UC_LoginPage";
            this.Size = new System.Drawing.Size(850, 393);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox login_textBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel login_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel password_label;
        private Guna.UI2.WinForms.Guna2TextBox password_textBox;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button error_indicator;
        public Action UserFindHandler;
        public Action<string, string> ToRegistrationHandler;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
