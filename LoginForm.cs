using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamQuiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_page.UserFindHandler += delegate
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            };
            login_page.ToRegistrationHandler += (l, p) =>
            {
                registration_page.FromLogin(l, p);
                registration_page.BringToFront();
                registration_button.Checked = true;
            };
            
            registration_page.UserRegisteredHandler += delegate
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            };
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login_page.BringToFront();
        }
        private void registration_button_Click(object sender, EventArgs e)
        {
            registration_page.BringToFront();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
