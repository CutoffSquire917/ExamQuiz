using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalsData;
using Guna.UI2.WinForms;

namespace ExamQuiz
{
    public partial class UC_LoginPage : UserControl
    {
        public UC_LoginPage()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text;
            string password = password_textBox.Text;
            User user = null;
            foreach (var tempUser in GlobalData.usersData.Items)
            {
                if (tempUser.Login == login)
                {
                   user = tempUser;
                }
            }
            if (user == null)
            {
                ToRegistrationHandler?.Invoke(login, password);
                return;
            }
            if (user.Password == password)
            {
                GlobalsData.Account.user = user;
                UserFindHandler?.Invoke();
            }
            else
            {
                this.error_indicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                this.error_indicator.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                this.error_indicator.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(login_textBox.Text)) && login_textBox.Text.Length > 3 && !(string.IsNullOrWhiteSpace(password_textBox.Text)))
            {
                if (this.login_button.Cursor == System.Windows.Forms.Cursors.Default)
                {
                    this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.login_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
                    this.login_button.Click += new System.EventHandler(this.login_button_Click);
                }
            }
            else
            {
                if (this.login_button.Cursor == System.Windows.Forms.Cursors.Hand)
                {
                    this.login_button.Cursor = System.Windows.Forms.Cursors.Default;
                    this.login_button.FillColor = System.Drawing.Color.Silver;
                    this.login_button.HoverState.FillColor = System.Drawing.Color.Silver;
                }
            }
        }
    }
}
