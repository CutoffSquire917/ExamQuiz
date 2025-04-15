using System;

namespace ExamQuiz
{
    partial class UC_QuizzesPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>




        private void InitializeComponent()
        {
            this.pagesName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.quizAuthor_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizCreatedBy_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).BeginInit();
            this.quiz_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagesName_label
            // 
            this.pagesName_label.AutoSize = false;
            this.pagesName_label.BackColor = System.Drawing.Color.Transparent;
            this.pagesName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.pagesName_label.Location = new System.Drawing.Point(50, 20);
            this.pagesName_label.Name = "pagesName_label";
            this.pagesName_label.Size = new System.Drawing.Size(261, 59);
            this.pagesName_label.TabIndex = 0;
            this.pagesName_label.Text = "Quizess";
            // 
            // quiz_image
            // 
            this.quiz_image.BackColor = System.Drawing.Color.Transparent;
            this.quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiz_image.BorderRadius = 30;
            this.quiz_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.quiz_image.Image = global::ExamQuiz.Properties.Resources.default_image;
            this.quiz_image.ImageRotate = 0F;
            this.quiz_image.Location = new System.Drawing.Point(0, 0);
            this.quiz_image.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_image.Name = "quiz_image";
            this.quiz_image.ShadowDecoration.BorderRadius = 30;
            this.quiz_image.ShadowDecoration.Depth = 10;
            this.quiz_image.Size = new System.Drawing.Size(822, 213);
            this.quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quiz_image.TabIndex = 1;
            this.quiz_image.TabStop = false;
            this.quiz_image.Click += new System.EventHandler(this.open_quiz_Click);
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Controls.Add(this.quizAuthor_label);
            this.quiz_panel.Controls.Add(this.quizCreatedBy_label);
            this.quiz_panel.Controls.Add(this.quizName_label);
            this.quiz_panel.Controls.Add(this.quiz_image);
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(50, 85);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Enabled = true;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.quiz_panel.Size = new System.Drawing.Size(822, 276);
            this.quiz_panel.TabIndex = 2;
            // 
            // quizAuthor_label
            // 
            this.quizAuthor_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizAuthor_label.AutoSize = false;
            this.quizAuthor_label.BackColor = System.Drawing.Color.Transparent;
            this.quizAuthor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizAuthor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.quizAuthor_label.Location = new System.Drawing.Point(606, 240);
            this.quizAuthor_label.Margin = new System.Windows.Forms.Padding(0);
            this.quizAuthor_label.Name = "quizAuthor_label";
            this.quizAuthor_label.Size = new System.Drawing.Size(216, 32);
            this.quizAuthor_label.TabIndex = 4;
            this.quizAuthor_label.Text = "Cutoffsquire917";
            this.quizAuthor_label.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // quizCreatedBy_label
            // 
            this.quizCreatedBy_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizCreatedBy_label.AutoSize = false;
            this.quizCreatedBy_label.BackColor = System.Drawing.Color.Transparent;
            this.quizCreatedBy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizCreatedBy_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.quizCreatedBy_label.Location = new System.Drawing.Point(606, 216);
            this.quizCreatedBy_label.Margin = new System.Windows.Forms.Padding(0);
            this.quizCreatedBy_label.Name = "quizCreatedBy_label";
            this.quizCreatedBy_label.Size = new System.Drawing.Size(216, 26);
            this.quizCreatedBy_label.TabIndex = 3;
            this.quizCreatedBy_label.Text = "Created by";
            this.quizCreatedBy_label.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // quizName_label
            // 
            this.quizName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizName_label.AutoSize = false;
            this.quizName_label.BackColor = System.Drawing.Color.Transparent;
            this.quizName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.quizName_label.Location = new System.Drawing.Point(50, 222);
            this.quizName_label.Name = "quizName_label";
            this.quizName_label.Size = new System.Drawing.Size(442, 50);
            this.quizName_label.TabIndex = 2;
            this.quizName_label.Text = "Quiz name";
            // 
            // UC_QuizzesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.pagesName_label);
            this.Name = "UC_QuizzesPage";
            this.Size = new System.Drawing.Size(922, 686);
            this.Load += new System.EventHandler(this.UC_QuizzesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).EndInit();
            this.quiz_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private Guna.UI2.WinForms.Guna2HtmlLabel pagesName_label;
        private Guna.UI2.WinForms.Guna2PictureBox quiz_image;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizName_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizCreatedBy_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizAuthor_label;

        public event Action<Quiz> OpenQuizHandler;
        

    }
}
