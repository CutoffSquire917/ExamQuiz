using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalsData;
using Guna.UI2.WinForms;

namespace ExamQuiz
{
    public partial class UC_SettingsPage : UserControl
    {
        public UC_SettingsPage()
        {
            InitializeComponent();
        }

        private void UC_SettingsPage_Load(object sender, EventArgs e)
        {
            this.dateTimePicker.MaxDate = DateTime.Today;
            if (Account.user != null)
            {
                this.dateTimePicker.Value = Account.user.BithdayDate;
            }
        }

        private void resetPassword_button_Click(object sender, EventArgs e)
        {
            if (Account.user.Password == this.oldPassword_textBox.Text)
            {
                Account.user.Password = this.newPassword_textBox.Text;
                GlobalsData.GlobalData.usersData.Preservation();
                this.oldPassword_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
                this.oldPassword_textBox.PlaceholderForeColor = System.Drawing.Color.YellowGreen;
                this.newPassword_textBox.BorderColor = System.Drawing.Color.YellowGreen;
                this.newPassword_textBox.PlaceholderForeColor = System.Drawing.Color.YellowGreen;

                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();
                    this.oldPassword_textBox.BorderColor = System.Drawing.Color.Silver;
                    this.oldPassword_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.newPassword_textBox.BorderColor = System.Drawing.Color.Silver;
                    this.newPassword_textBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.oldPassword_textBox.Text = "";
                    this.newPassword_textBox.Text = "";
                };
                timer.Start();
            }
            else
            {
                this.oldPassword_textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.newPassword_textBox.Text)) && this.newPassword_textBox.Text.Length > 7 && !(string.IsNullOrWhiteSpace(this.oldPassword_textBox.Text)) && this.oldPassword_textBox.Text.Length > 7 && this.oldPassword_textBox.Text != this.newPassword_textBox.Text)
            {
                if (this.resetPassword_button.Cursor != System.Windows.Forms.Cursors.Hand)
                {
                    this.resetPassword_button.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.resetPassword_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.resetPassword_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
                    this.resetPassword_button.Click += new System.EventHandler(this.resetPassword_button_Click);
                }
            }
            else
            {
                if (this.resetPassword_button.Cursor != System.Windows.Forms.Cursors.Default)
                {
                    this.resetPassword_button.Cursor = System.Windows.Forms.Cursors.Default;
                    this.resetPassword_button.FillColor = System.Drawing.Color.Silver;
                    this.resetPassword_button.HoverState.FillColor = System.Drawing.Color.Silver;
                    this.resetPassword_button.Click -= new System.EventHandler(this.resetPassword_button_Click);
                }
            }
        }

        private void resetBirthDate_button_Click(object sender, EventArgs e)
        {
            Account.user.BithdayDate = this.dateTimePicker.Value;
            GlobalsData.GlobalData.usersData.Preservation();
            this.dateTimePicker.CheckedState.BorderColor = System.Drawing.Color.YellowGreen;
            this.dateTimePicker.BorderColor = System.Drawing.Color.YellowGreen;

            this.resetBirthDate_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.resetBirthDate_button.FillColor = System.Drawing.Color.Silver;
            this.resetBirthDate_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.resetBirthDate_button.Click -= new System.EventHandler(this.resetBirthDate_button_Click);

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                this.dateTimePicker.CheckedState.BorderColor = System.Drawing.Color.Silver;
                this.dateTimePicker.BorderColor = System.Drawing.Color.Silver;
            };
            timer.Start();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker.Value != Account.user.BithdayDate)
            {
                if (this.resetBirthDate_button.Cursor != System.Windows.Forms.Cursors.Hand)
                {
                    this.resetBirthDate_button.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.resetBirthDate_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.resetBirthDate_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
                    this.resetBirthDate_button.Click += new System.EventHandler(this.resetBirthDate_button_Click);
                }
            }
            else
            {
                if (this.resetBirthDate_button.Cursor != System.Windows.Forms.Cursors.Default)
                {
                    this.resetBirthDate_button.Cursor = System.Windows.Forms.Cursors.Default;
                    this.resetBirthDate_button.FillColor = System.Drawing.Color.Silver;
                    this.resetBirthDate_button.HoverState.FillColor = System.Drawing.Color.Silver;
                    this.resetBirthDate_button.Click -= new System.EventHandler(this.resetBirthDate_button_Click);
                }
                
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            OpenLoginFormHandler?.Invoke();
        }
    }
}
