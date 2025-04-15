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
    public partial class UC_ResultPage : UserControl
    {
        public UC_ResultPage(Quiz quiz, bool[] results)
        {
            ResultQuiz = quiz;
            Results = results;
            InitializeComponent();
        }

        private void UC_ResultPage_Load(object sender, EventArgs e)
        {
            double resultInPercentage = Math.Round((100.0 / (double)ResultQuiz.Questions.Count) * (double)Results.Count(r => r == true), 1);
            Account.user.UserHistory.Add((ResultQuiz, resultInPercentage, DateTime.Today));

            this.quizName_label.Text = ResultQuiz.Name;
            this.quizAuthor_label.Text = ResultQuiz.Author;
            this.scoreInPoints_label.Text = $"{Results.Count(r => r == true)} / {ResultQuiz.Questions.Count}";
            this.result_progressBar.Value = (int)resultInPercentage;
            this.result_progressBar.Text = resultInPercentage.ToString() + " %";
            this.scoreInPercentage_label.Text = resultInPercentage.ToString() + " / 100 %";
            

        }

        private void tryAgain_button_Click(object sender, EventArgs e)
        {
            QuizCloseHandler?.Invoke();
        }
        private void quit_button_Click(object sender, EventArgs e)
        {
            QuizCloseHandler?.Invoke();
        }
    }
}
