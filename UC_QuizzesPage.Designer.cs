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
            this.quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizCreatedBy_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizAuthor_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            // UC_QuizzesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pagesName_label);
            this.Name = "UC_QuizzesPage";
            this.Size = new System.Drawing.Size(922, 686);
            this.Load += new System.EventHandler(this.UC_QuizzesPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private Guna.UI2.WinForms.Guna2HtmlLabel pagesName_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizName_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizCreatedBy_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizAuthor_label;

        public event Action<Quiz> OpenQuizHandler;
        

    }
}
