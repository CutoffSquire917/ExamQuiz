using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamQuiz.Properties;
using GlobalsData;
using Guna.UI2.WinForms;

namespace ExamQuiz
{
    public partial class UC_HistoryPage : UserControl
    {
        public UC_HistoryPage()
        {
            InitializeComponent();
        }

        private void UC_HistoryPage_Load(object sender, EventArgs e)
        {
            UC_HistoryPage_Update();
        }

        public void UC_HistoryPage_Update()
        {
            if (Account.user == null)
            {
                return;
            }
            for (int i = 0; i < GlobalsData.Account.user.UserHistory.Count; i++)
            {
                var panelToRemove = this.Controls.Find($"quiz{i}_panel", true).FirstOrDefault() as Guna2Panel;

                if (panelToRemove != null)
                {
                    this.Controls.Remove(panelToRemove);
                    panelToRemove.Dispose();
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < GlobalsData.Account.user.UserHistory.Count; i++)
            {
                Quiz historyQuiz = null;
                foreach (var quiz in GlobalData.quizzesData.Items)
                {
                    if (quiz.Name == Account.user.UserHistory[i].Item1)
                    {
                        historyQuiz = quiz;
                    }
                }

                #region quiz_image
                var quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();

                quiz_image.BackColor = System.Drawing.Color.Transparent;
                quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                quiz_image.BorderRadius = 30;
                quiz_image.Cursor = System.Windows.Forms.Cursors.Hand;
                quiz_image.Dock = System.Windows.Forms.DockStyle.Left;


                if (historyQuiz != null)
                {
                    if (File.Exists(historyQuiz.Image))
                    {
                        quiz_image.Image = Image.FromFile(historyQuiz.Image);
                        quiz_image.Tag = historyQuiz;
                        quiz_image.Click += new System.EventHandler(OpenQuizFromHistory);
                    }
                }
                quiz_image.Location = new System.Drawing.Point(0, 0);
                quiz_image.Name = $"quiz{i}_image";
                quiz_image.Size = new System.Drawing.Size(235, 100);
                quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                #endregion

                #region quizName_label
                var quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();

                quizName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                quizName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                quizName_label.MaximumSize = new System.Drawing.Size(210, 100);
                quizName_label.Location = new System.Drawing.Point(255, 25);
                quizName_label.Name = $"quizName{i}_label";
                quizName_label.Text = Account.user.UserHistory[i].Item1;

                #endregion

                #region result_label
                var result_label = new Guna.UI2.WinForms.Guna2HtmlLabel();

                result_label.AutoSize = false;
                result_label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                result_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                result_label.Location = new System.Drawing.Point(425, 18);
                result_label.Name = $"result{i}_label";
                result_label.Size = new System.Drawing.Size(100, 30);
                result_label.Text = Account.user.UserHistory[i].Item2 + " %";
                result_label.TextAlignment = ContentAlignment.TopRight;

                #endregion

                #region resultBar_progressBar
                var resultBar_progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();

                resultBar_progressBar.Backwards = true;
                resultBar_progressBar.FillColor = System.Drawing.Color.Red;
                resultBar_progressBar.FillThickness = 7;
                resultBar_progressBar.Location = new System.Drawing.Point(535, 21);
                resultBar_progressBar.Minimum = 0;
                resultBar_progressBar.Name = $"resultBar{i}_progressBar";
                resultBar_progressBar.ProgressColor = System.Drawing.Color.Lime;
                resultBar_progressBar.ProgressColor2 = System.Drawing.Color.Lime;
                resultBar_progressBar.ProgressThickness = 7;
                resultBar_progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                resultBar_progressBar.Size = new System.Drawing.Size(30, 30);
                resultBar_progressBar.Value = (int)Account.user.UserHistory[i].Item2;

                #endregion

                #region date_label
                var date_label = new Guna.UI2.WinForms.Guna2HtmlLabel();

                date_label.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                date_label.Location = new System.Drawing.Point(480, 55);
                date_label.Name = $"date{i}_label";
                date_label.Text = Account.user.UserHistory[i].Item3.ToShortDateString();

                #endregion

                #region quiz_panel
                var quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
                quiz_panel.BackColor = System.Drawing.Color.Transparent;
                quiz_panel.BorderRadius = 30;
                quiz_panel.Controls.Add(resultBar_progressBar);
                quiz_panel.Controls.Add(result_label);
                quiz_panel.Controls.Add(date_label);
                quiz_panel.Controls.Add(quizName_label);
                quiz_panel.Controls.Add(quiz_image);
                quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
                quiz_panel.Location = new System.Drawing.Point(37, 81 + (91 * i));
                quiz_panel.Name = $"quiz{i}_panel";
                quiz_panel.ShadowDecoration.BorderRadius = 30;
                quiz_panel.ShadowDecoration.Depth = 5;
                quiz_panel.ShadowDecoration.Enabled = true;
                quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
                quiz_panel.Size = new System.Drawing.Size(617, 81);
                quiz_panel.BringToFront();
                quiz_panel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(quiz_image)).BeginInit();
                SuspendLayout();

                this.Controls.Add(quiz_panel);

                #endregion
            }
        }
    
        public void OpenQuizFromHistory(object sender, EventArgs e)
        {
            OpenQuizHandler?.Invoke((Quiz)((Guna2PictureBox)sender).Tag);
        }

        
    }
}
