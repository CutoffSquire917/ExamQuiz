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
    public partial class UC_ConcreteQuizPage : UserControl
    {
        public UC_ConcreteQuizPage()
        {
            InitializeComponent();
        }

        public void UpdateQuiz(Quiz quiz)
        {
            if (quiz == null)
            {
                throw new ArgumentNullException("Quiz can`t be null");
            }
            ConcreteQuiz = quiz;
            quizName_label.Text = ConcreteQuiz.Name;
            quiz_image.Image = Image.FromFile(quiz.Image);
            quizAuthor_label.Text = $"Created by {ConcreteQuiz.Author}";

            description_label.Text = quiz.Description;

            var noneLabelToRemove = this.top_panel.Controls.Find("none_label", true).FirstOrDefault() as Guna2HtmlLabel;
            if (noneLabelToRemove != null)
            {
                this.Controls.Remove(noneLabelToRemove);
                noneLabelToRemove.Dispose();
            }
            for (int i = 0; i < 10; i++)
            {
                var labelToRemove = this.top_panel.Controls.Find($"topTitle{i}_label", true).FirstOrDefault() as Guna2HtmlLabel;

                if (labelToRemove != null)
                {
                    this.Controls.Remove(labelToRemove);
                    labelToRemove.Dispose();
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < quiz.TopHistory.Count; i++)
            {
                var top_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
                top_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                top_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                top_label.Location = new System.Drawing.Point(0, 23 * i);
                top_label.Name = $"topTitle{i}_label";
                top_label.Size = new System.Drawing.Size(59, 51);
                top_label.Text = $"{i + 1}. {quiz.TopHistory[i].Item1} ({quiz.TopHistory[i].Item2}%)";
                this.top_panel.Controls.Add(top_label);
            }
            if (quiz.TopHistory.Count == 0)
            {
                var top_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
                top_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                top_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                top_label.Location = new System.Drawing.Point(0, 0);
                top_label.Name = $"none_label";
                top_label.Size = new System.Drawing.Size(59, 51);
                top_label.Text = "There's no one here yet";
                this.top_panel.Controls.Add(top_label);
            }
        }

        private void start_quiz_Click(object sender, EventArgs e)
        {
            StartQuizHandler?.Invoke(ConcreteQuiz);
        }
    }
}
