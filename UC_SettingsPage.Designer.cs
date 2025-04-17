using System;

namespace ExamQuiz
{
    partial class UC_SettingsPage
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resetPassword_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.resetPassword_button = new Guna.UI2.WinForms.Guna2Button();
            this.newPassword_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.newPassword_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPassword_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.oldPassword_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.resetBirthDate_button = new Guna.UI2.WinForms.Guna2Button();
            this.resetBirthDate_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logout_button = new Guna.UI2.WinForms.Guna2Button();
            this.quiz_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(261, 63);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Settings";
            // 
            // resetPassword_label
            // 
            this.resetPassword_label.AutoSize = false;
            this.resetPassword_label.BackColor = System.Drawing.Color.Transparent;
            this.resetPassword_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.resetPassword_label.Location = new System.Drawing.Point(25, 15);
            this.resetPassword_label.Margin = new System.Windows.Forms.Padding(25, 15, 0, 0);
            this.resetPassword_label.Name = "resetPassword_label";
            this.resetPassword_label.Size = new System.Drawing.Size(414, 41);
            this.resetPassword_label.TabIndex = 4;
            this.resetPassword_label.Text = "Reset password";
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Controls.Add(this.resetPassword_button);
            this.quiz_panel.Controls.Add(this.newPassword_label);
            this.quiz_panel.Controls.Add(this.newPassword_textBox);
            this.quiz_panel.Controls.Add(this.oldPassword_label);
            this.quiz_panel.Controls.Add(this.oldPassword_textBox);
            this.quiz_panel.Controls.Add(this.resetPassword_label);
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(50, 80);
            this.quiz_panel.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Enabled = true;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.quiz_panel.Size = new System.Drawing.Size(822, 170);
            this.quiz_panel.TabIndex = 7;
            // 
            // resetPassword_button
            // 
            this.resetPassword_button.Animated = true;
            this.resetPassword_button.AutoRoundedCorners = true;
            this.resetPassword_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.resetPassword_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetPassword_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetPassword_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetPassword_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetPassword_button.FillColor = System.Drawing.Color.Silver;
            this.resetPassword_button.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword_button.ForeColor = System.Drawing.Color.White;
            this.resetPassword_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.resetPassword_button.Location = new System.Drawing.Point(633, 55);
            this.resetPassword_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.resetPassword_button.Name = "resetPassword_button";
            this.resetPassword_button.PressedColor = System.Drawing.Color.GhostWhite;
            this.resetPassword_button.Size = new System.Drawing.Size(150, 64);
            this.resetPassword_button.TabIndex = 20;
            this.resetPassword_button.Text = "Reset";
            // 
            // newPassword_label
            // 
            this.newPassword_label.AutoSize = false;
            this.newPassword_label.BackColor = System.Drawing.Color.Transparent;
            this.newPassword_label.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.newPassword_label.Location = new System.Drawing.Point(315, 71);
            this.newPassword_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.newPassword_label.Name = "newPassword_label";
            this.newPassword_label.Size = new System.Drawing.Size(293, 37);
            this.newPassword_label.TabIndex = 19;
            this.newPassword_label.Text = "New password";
            this.newPassword_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.Animated = true;
            this.newPassword_textBox.AutoRoundedCorners = true;
            this.newPassword_textBox.BorderColor = System.Drawing.Color.Silver;
            this.newPassword_textBox.BorderRadius = 18;
            this.newPassword_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassword_textBox.DefaultText = "";
            this.newPassword_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.newPassword_textBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.newPassword_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newPassword_textBox.Location = new System.Drawing.Point(310, 108);
            this.newPassword_textBox.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.newPassword_textBox.MaxLength = 20;
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.newPassword_textBox.PlaceholderText = "";
            this.newPassword_textBox.SelectedText = "";
            this.newPassword_textBox.Size = new System.Drawing.Size(270, 39);
            this.newPassword_textBox.TabIndex = 18;
            this.newPassword_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.newPassword_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // oldPassword_label
            // 
            this.oldPassword_label.AutoSize = false;
            this.oldPassword_label.BackColor = System.Drawing.Color.Transparent;
            this.oldPassword_label.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.oldPassword_label.Location = new System.Drawing.Point(25, 71);
            this.oldPassword_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.oldPassword_label.Name = "oldPassword_label";
            this.oldPassword_label.Size = new System.Drawing.Size(293, 37);
            this.oldPassword_label.TabIndex = 17;
            this.oldPassword_label.Text = "Old password";
            this.oldPassword_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.Animated = true;
            this.oldPassword_textBox.AutoRoundedCorners = true;
            this.oldPassword_textBox.BorderColor = System.Drawing.Color.Silver;
            this.oldPassword_textBox.BorderRadius = 18;
            this.oldPassword_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPassword_textBox.DefaultText = "";
            this.oldPassword_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPassword_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPassword_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassword_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassword_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.oldPassword_textBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.oldPassword_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.oldPassword_textBox.Location = new System.Drawing.Point(20, 108);
            this.oldPassword_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.oldPassword_textBox.MaxLength = 20;
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.oldPassword_textBox.PlaceholderText = "";
            this.oldPassword_textBox.SelectedText = "";
            this.oldPassword_textBox.Size = new System.Drawing.Size(270, 39);
            this.oldPassword_textBox.TabIndex = 8;
            this.oldPassword_textBox.TextOffset = new System.Drawing.Point(15, 0);
            this.oldPassword_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
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
            this.dateTimePicker.Location = new System.Drawing.Point(20, 81);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(461, 50);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.TextOffset = new System.Drawing.Point(15, 0);
            this.dateTimePicker.Value = new System.DateTime(2025, 4, 16, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.resetBirthDate_button);
            this.guna2Panel1.Controls.Add(this.dateTimePicker);
            this.guna2Panel1.Controls.Add(this.resetBirthDate_label);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(50, 280);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(822, 170);
            this.guna2Panel1.TabIndex = 21;
            // 
            // resetBirthDate_button
            // 
            this.resetBirthDate_button.Animated = true;
            this.resetBirthDate_button.AutoRoundedCorners = true;
            this.resetBirthDate_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.resetBirthDate_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBirthDate_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBirthDate_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBirthDate_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBirthDate_button.FillColor = System.Drawing.Color.Silver;
            this.resetBirthDate_button.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBirthDate_button.ForeColor = System.Drawing.Color.White;
            this.resetBirthDate_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.resetBirthDate_button.Location = new System.Drawing.Point(633, 55);
            this.resetBirthDate_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.resetBirthDate_button.Name = "resetBirthDate_button";
            this.resetBirthDate_button.PressedColor = System.Drawing.Color.GhostWhite;
            this.resetBirthDate_button.Size = new System.Drawing.Size(150, 64);
            this.resetBirthDate_button.TabIndex = 20;
            this.resetBirthDate_button.Text = "Reset";
            // 
            // resetBirthDate_label
            // 
            this.resetBirthDate_label.AutoSize = false;
            this.resetBirthDate_label.BackColor = System.Drawing.Color.Transparent;
            this.resetBirthDate_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBirthDate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.resetBirthDate_label.Location = new System.Drawing.Point(25, 15);
            this.resetBirthDate_label.Margin = new System.Windows.Forms.Padding(25, 15, 0, 0);
            this.resetBirthDate_label.Name = "resetBirthDate_label";
            this.resetBirthDate_label.Size = new System.Drawing.Size(414, 41);
            this.resetBirthDate_label.TabIndex = 4;
            this.resetBirthDate_label.Text = "Reset birth date";
            // 
            // logout_button
            // 
            this.logout_button.Animated = true;
            this.logout_button.BorderRadius = 15;
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_button.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.logout_button.Location = new System.Drawing.Point(683, 592);
            this.logout_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.logout_button.Name = "logout_button";
            this.logout_button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.logout_button.Size = new System.Drawing.Size(189, 64);
            this.logout_button.TabIndex = 21;
            this.logout_button.Text = "Logout";
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // UC_SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UC_SettingsPage";
            this.Size = new System.Drawing.Size(922, 686);
            this.Load += new System.EventHandler(this.UC_SettingsPage_Load);
            this.quiz_panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel resetPassword_label;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Guna.UI2.WinForms.Guna2TextBox oldPassword_textBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel newPassword_label;
        private Guna.UI2.WinForms.Guna2TextBox newPassword_textBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel oldPassword_label;
        private Guna.UI2.WinForms.Guna2Button resetPassword_button;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button resetBirthDate_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel resetBirthDate_label;
        private Guna.UI2.WinForms.Guna2Button logout_button;
        public Action OpenLoginFormHandler;
    }
}
