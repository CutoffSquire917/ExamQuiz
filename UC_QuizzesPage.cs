using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalsData;


namespace ExamQuiz
{
    public partial class UC_QuizzesPage : UserControl
    {
        public UC_QuizzesPage()
        {
            InitializeComponent();
        }

        private void open_quiz_Click(object sender, EventArgs e)
        {
            OpenQuizHandler?.Invoke((Quiz)quiz_image.Tag);
        }

        private void UC_QuizzesPage_Load(object sender, EventArgs e)
        {
            quiz_image.Tag = GlobalData.quizzesData.Items[0];
            Quiz quiz = (Quiz)quiz_image.Tag;

            quizName_label.Text = quiz.Name;
            quizAuthor_label.Text = GlobalData.quizzesData.Items[0].Author;

        }

    }
}
