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

namespace ExamQuiz
{
    public partial class UC_RegistrationPage : UserControl
    {
        public UC_RegistrationPage()
        {
            InitializeComponent();
        }
        private void UC_RegistrationPage_Load(object sender, EventArgs e)
        {
            this.dateTimePicker.MaxDate = DateTime.Today;
        }

        public void FromLogin(string login, string password)
        {
            login_textBox.Text = login;
            password_textBox.Text = password;
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text;
            string password = password_textBox.Text;
            foreach (var tempUser in GlobalData.usersData.Items)
            {
                if (tempUser.Login == login)
                {
                    this.loginError_indicator.Visible = true;
                }
                else
                {
                    if (this.loginError_indicator.Visible)
                    {
                        this.loginError_indicator.Visible = false;
                    }
                }
            }
            if (!(User.TrySetPassword(password)))
            {
                this.passwordError_indicator.Visible = true;
            }
            else
            {
                this.passwordError_indicator.Visible = false;
            }
            if (this.loginError_indicator.Visible || this.passwordError_indicator.Visible)
            {
                return;
            }

            User user = new User(login, password, dateTimePicker.Value);
            GlobalsData.GlobalData.usersData.Items.Add(user);
            GlobalsData.Account.user = user;
            GlobalsData.GlobalData.usersData.Preservation();
            UserRegisteredHandler?.Invoke();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(login_textBox.Text)) && login_textBox.Text.Length > 3 && !(string.IsNullOrWhiteSpace(password_textBox.Text)) && password_textBox.Text.Length > 7)
            {
                if (this.registration_button.Cursor == System.Windows.Forms.Cursors.Default)
                {
                    this.registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.registration_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    this.registration_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
                    this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
                }
            }
            else
            {
                if (this.registration_button.Cursor == System.Windows.Forms.Cursors.Hand)
                {
                    this.registration_button.Cursor = System.Windows.Forms.Cursors.Default;
                    this.registration_button.FillColor = System.Drawing.Color.Silver;
                    this.registration_button.HoverState.FillColor = System.Drawing.Color.Silver;
                }
            }
        }

    }
}
