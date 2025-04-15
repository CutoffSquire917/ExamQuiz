using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ExamQuiz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Guna2ShadowForm FormShadow = new Guna2ShadowForm();
            FormShadow.SetShadowForm(this);

            quizzes_page.OpenQuizHandler += (concreteQuiz) =>
            {
                concreteQuiz_page.UpdateQuiz(concreteQuiz);
                close2_button.Text = "RETURN";
                close2_button.Click -= new System.EventHandler(this.close2_button_Click);
                close2_button.Click += new System.EventHandler(this.return_button_Click);
                concreteQuiz_page.BringToFront();
            };

            history_page.OpenQuizHandler += (quizName) =>
            {
                foreach (var quiz in GlobalsData.GlobalData.quizzesData.Items)
                {
                    if (quizName == quiz.Name)
                    {
                        concreteQuiz_page.UpdateQuiz(quiz);
                        break;
                    }
                }
                quizzes_button.Checked = true;
                close2_button.Text = "RETURN";
                close2_button.Click -= new System.EventHandler(this.close2_button_Click);
                close2_button.Click += new System.EventHandler(this.return_button_Click);
                concreteQuiz_page.BringToFront();
            };

            concreteQuiz_page.StartQuizHandler += (currentQuiz) =>
            {
                this.Hide();
                CurrentQuizFrom currentQuizFrom = new CurrentQuizFrom(currentQuiz);
                currentQuizFrom.FormClosed += (s, args) => this.Show();
                currentQuizFrom.Show();
            };
        }

        private void quizzes_button_CheckedChanged(object sender, EventArgs e)
        {
            if (quizzes_button.Checked)
            {
                quizzes_page.BringToFront();
            }
        }
        private void history_button_CheckedChanged(object sender, EventArgs e)
        {
            if (history_button.Checked)
            {
                history_page.BringToFront();
                history_page.UC_HistoryPage_Update();
            }
            if (close2_button.Text == "RETURN")
            {
                close2_button.Click -= new System.EventHandler(this.return_button_Click);
                close2_button.Click += new System.EventHandler(this.close2_button_Click);
                close2_button.Text = "EXIT";
            }
        }
        private void created_button_CheckedChanged(object sender, EventArgs e)
        {
            if (created_button.Checked)
            {
                created_page.BringToFront();
            }
            if (close2_button.Text == "RETURN")
            {
                close2_button.Click -= new System.EventHandler(this.return_button_Click);
                close2_button.Click += new System.EventHandler(this.close2_button_Click);
                close2_button.Text = "EXIT";
            }
        }
        private void settings_button_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_button.Checked)
            {
                settings_page.BringToFront();
            }
            if (close2_button.Text == "RETURN")
            {
                close2_button.Click -= new System.EventHandler(this.return_button_Click);
                close2_button.Click += new System.EventHandler(this.close2_button_Click);
                close2_button.Text = "EXIT";
            }
        }

        private void close2_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void return_button_Click(object sender, EventArgs e)
        {
            close2_button.Click -= new System.EventHandler(this.return_button_Click);
            close2_button.Click += new System.EventHandler(this.close2_button_Click);
            close2_button.Text = "EXIT";
            quizzes_page.BringToFront();
        }
    }
}
