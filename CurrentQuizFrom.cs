using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ExamQuiz
{
    public partial class CurrentQuizFrom : Form
    {
        public CurrentQuizFrom()
        {
            InitializeComponent();
        }

        public CurrentQuizFrom(Quiz quiz)
        {
            if (quiz == null)
            {
                throw new ArgumentNullException("Quiz can`t be null");
            }
            CurrentQuiz = quiz;
            Results = new bool[CurrentQuiz.Questions.Count];
            InitializeComponent();
        }

        private void CurrentQuizFrom_Load(object sender, EventArgs e)
        {
            LoadQuistion(CurrentQuiz.Questions[Index]);
        }
        private void LoadQuistion(Question question)
        {
            System.Drawing.Color[] buttonsColors = {
                System.Drawing.Color.Red,
                System.Drawing.Color.MediumBlue,
                System.Drawing.Color.LimeGreen,
                System.Drawing.Color.Gold,
                System.Drawing.Color.Magenta,
                System.Drawing.Color.Turquoise
            };
            System.Drawing.Color[] buttonsStateColors = {
                System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))
            };

            quistion_label.Text = question.question;
            numberOf_label.Text = $"{Index + 1} / {CurrentQuiz.Questions.Count}";
            bool singleSample = question.answers.Count(a => a.Value) > 1 ? false : true;
            check_button.Visible = !(singleSample);
            for (int i = 0; i < question.answers.Count; i++)
            {
                var buttonSize = (1142 - (10 * (question.answers.Count - 1))) / question.answers.Count;
                
                var button = new Guna.UI2.WinForms.Guna2Button();
                button.Text = question.answers.ElementAt(i).Key;
                button.Location = i > 0 ? new System.Drawing.Point((buttonSize * i) + (10 * i), 0) : new System.Drawing.Point(0, 0);
                button.Size = new System.Drawing.Size(buttonSize, 250);
                button.BorderColor = buttonsColors[i];
                button.PressedColor = buttonsColors[i];
                button.CheckedState.FillColor = buttonsStateColors[i];
                button.Tag = question.answers.ElementAt(i).Value;
                if (singleSample)
                {
                    button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
                    button.Click += new System.EventHandler(answer_Click);
                }
                else
                {
                    button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
                    button.CheckedChanged += new System.EventHandler(answer_CheckedChanged);
                }

                if (question.answers.ElementAt(i).Value)
                {
                    IsTrueAnswer += delegate {
                        button.FillColor = System.Drawing.Color.YellowGreen;
                        button.HoverState.FillColor = System.Drawing.Color.YellowGreen;
                    };
                }

                button.HoverState.FillColor = System.Drawing.Color.White;
                button.FillColor = System.Drawing.Color.WhiteSmoke;
                button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                button.Animated = true;
                button.BorderRadius = 30;
                button.BorderThickness = 1;
                
                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.FocusedColor = System.Drawing.Color.LightBlue;
                button.Margin = new System.Windows.Forms.Padding(5);
                button.Name = $"answer{i}_button";
                button.TabIndex = 20;

                this.answers_panel.Controls.Add(button);

            }
            

        }
        private void FinalResults()
        {
            var result_page = new ExamQuiz.UC_ResultPage(CurrentQuiz, Results);
            result_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            result_page.Location = new System.Drawing.Point(0, 34);
            result_page.Margin = new System.Windows.Forms.Padding(0);
            result_page.Name = "result_page";
            result_page.TabIndex = 0;
            result_page.Dock = DockStyle.Fill;
            this.Controls.Add(result_page);
            result_page.Size = new System.Drawing.Size(1500, 900);
            result_page.BringToFront();
            result_page.QuizCloseHandler += delegate
            {
                this.Close();
            };
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void answer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CurrentQuiz.Questions[Index].answers.Count; i++)
            {
                var buttonToRemove = this.Controls.Find($"answer{i}_button", true).FirstOrDefault() as Guna2Button;
                buttonToRemove.Click -= answer_Click;
            }
            IsTrueAnswer?.Invoke();
            var button = sender as Guna2Button;
            if (!((bool)button.Tag))
            {
                button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                Results[Index] = false;
            }
            else
            {
                Results[Index] = true;
            }
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                for (int i = 0; i < CurrentQuiz.Questions[Index].answers.Count; i++)
                {
                    var buttonToRemove = this.Controls.Find($"answer{i}_button", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;

                    if (buttonToRemove != null)
                    {
                        this.Controls.Remove(buttonToRemove);
                        buttonToRemove.Dispose();
                    }
                }
                if (Index + 1 >= CurrentQuiz.Questions.Count)
                {
                    FinalResults();
                }
                else
                {
                    Index++;
                    LoadQuistion(CurrentQuiz.Questions[Index]);
                }
            };
            timer.Start();
        }
        private void answer_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            if (button.Checked)
            {
                if (Pressed.Count <= 0)
                {
                    check_button.Click += new System.EventHandler(check_button_Click);
                    check_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
                    check_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
                    check_button.Cursor = System.Windows.Forms.Cursors.Hand;
                }
                Pressed.Add(button);
            }
            else
            {
                Pressed.Remove(button);
                if (Pressed.Count <= 0)
                {
                    check_button.Click -= check_button_Click;
                    check_button.FillColor = System.Drawing.Color.Silver;
                    check_button.HoverState.FillColor = System.Drawing.Color.Silver;
                    check_button.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
        }
        private void check_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CurrentQuiz.Questions[Index].answers.Count; i++)
            {
                var buttonToRemove = this.Controls.Find($"answer{i}_button", true).FirstOrDefault() as Guna2Button;
                buttonToRemove.Click -= answer_CheckedChanged;
            }
            if (Pressed.Count(b => (bool)b.Tag) == CurrentQuiz.Questions[Index].answers.Count(a => a.Value) && Pressed.Count == CurrentQuiz.Questions[Index].answers.Count(a => a.Value))
            {
                Results[Index] = true;
            }
            else
            {
                Results[Index] = false;
            }
            foreach (var btn in Pressed.ToList())
            {
                btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                btn.Checked = false;
            }
            IsTrueAnswer?.Invoke();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                for (int i = 0; i < CurrentQuiz.Questions[Index].answers.Count; i++)
                {
                    var buttonToRemove = this.Controls.Find($"answer{i}_button", true).FirstOrDefault() as Guna2Button;

                    if (buttonToRemove != null)
                    {
                        this.Controls.Remove(buttonToRemove);
                        buttonToRemove.Dispose();
                    }
                }
                Pressed.Clear();
                if (Index + 1 >= CurrentQuiz.Questions.Count)
                {
                    FinalResults();
                }
                else
                {
                    Index++;
                    LoadQuistion(CurrentQuiz.Questions[Index]);
                }
            };
            timer.Start();
        }
        private void finish_button_Click(object sender, EventArgs e)
        {
            FinalResults();
        }
    }
}
