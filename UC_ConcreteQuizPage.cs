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
            quizAuthor_label.Text = $"Created by {ConcreteQuiz.Author}";
        }

        private void start_quiz_Click(object sender, EventArgs e)
        {
            StartQuizHandler?.Invoke(ConcreteQuiz);
        }
    }
}
