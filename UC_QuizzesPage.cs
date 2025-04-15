using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamQuiz.Properties;
using GlobalsData;
using Guna.UI2.WinForms;


namespace ExamQuiz
{
    public partial class UC_QuizzesPage : UserControl
    {
        public UC_QuizzesPage()
        {
            InitializeComponent();
        }


        private void UC_QuizzesPage_Load(object sender, EventArgs e)
        {
            UC_QuizzesPage_Update();
        }
        public void UC_QuizzesPage_Update()
        {
            for (int i = 0; i < GlobalData.quizzesData.Items.Count; i++)
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
            for (int i = 0; i < GlobalData.quizzesData.Items.Count; i++)
            {
                var quiz = GlobalData.quizzesData.Items[i];

                #region quiz_image
                var quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();

                //quiz_image.BackColor = System.Drawing.Color.Transparent;
                //quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                quiz_image.BorderRadius = 30;
                quiz_image.Cursor = System.Windows.Forms.Cursors.Hand;
                quiz_image.Dock = System.Windows.Forms.DockStyle.Top;
                quiz_image.Image = Image.FromFile(quiz.Image);
                quiz_image.Location = new System.Drawing.Point(0, 0);
                quiz_image.Name = $"quiz{i}_image";
                quiz_image.Size = new System.Drawing.Size(822, 175);
                quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                quiz_image.Tag = quiz;
                quiz_image.Click += new System.EventHandler(this.open_quiz_Click);
                #endregion

                #region quizName_label
                var quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
                quizName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                quizName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                quizName_label.Location = new System.Drawing.Point(30, 180);
                quizName_label.Name = $"quizName{i}_label";
                quizName_label.Text = quiz.Name;
                #endregion

                #region quizCreatedBy_label
                var quizCreatedBy_label = new Guna.UI2.WinForms.Guna2HtmlLabel();

                quizCreatedBy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                quizCreatedBy_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                quizCreatedBy_label.Location = new System.Drawing.Point(515, 177);
                quizCreatedBy_label.Name = $"quizCreatedBy{i}_label";
                quizCreatedBy_label.Text = "Created by";
                #endregion
                #region quizAuthor_label
                var quizAuthor_label = new Guna.UI2.WinForms.Guna2HtmlLabel();

                quizAuthor_label.AutoSize = false;
                quizAuthor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                quizAuthor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                quizAuthor_label.Name = $"quizAuthor{i}_label";
                quizAuthor_label.Location = new System.Drawing.Point(385, 195);
                quizAuthor_label.Size = new System.Drawing.Size(200, 25);
                quizAuthor_label.Text = quiz.Author;
                quizAuthor_label.TextAlignment = ContentAlignment.MiddleRight;
                #endregion

                #region quiz_panel
                var quiz_panel = new Guna.UI2.WinForms.Guna2Panel();

                quiz_panel.BackColor = System.Drawing.Color.Transparent;
                quiz_panel.BorderRadius = 30;
                quiz_panel.Controls.Add(quizAuthor_label);
                quiz_panel.Controls.Add(quizCreatedBy_label);
                quiz_panel.Controls.Add(quizName_label);
                quiz_panel.Controls.Add(quiz_image);
                quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
                quiz_panel.Location = new System.Drawing.Point(37, 70 + (232 * i));
                quiz_panel.Name = $"quiz{i}_panel";
                quiz_panel.ShadowDecoration.BorderRadius = 30;
                quiz_panel.ShadowDecoration.Depth = 5;
                quiz_panel.ShadowDecoration.Enabled = true;
                quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
                quiz_panel.Size = new System.Drawing.Size(615, 222);

                this.Controls.Add(quiz_panel);
                #endregion
            }

        }
        
        private void open_quiz_Click(object sender, EventArgs e)
        {
            OpenQuizHandler?.Invoke((Quiz)((Guna2PictureBox)sender).Tag);
        }


    }

}
