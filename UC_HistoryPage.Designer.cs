using System;

namespace ExamQuiz
{
    partial class UC_HistoryPage
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
            this.SuspendLayout();
            // 
            // pagesName_label
            // 
            this.pagesName_label.AutoSize = false;
            this.pagesName_label.BackColor = System.Drawing.Color.Transparent;
            this.pagesName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.pagesName_label.Location = new System.Drawing.Point(50, 20);
            this.pagesName_label.Name = "pagesName_label";
            this.pagesName_label.Size = new System.Drawing.Size(261, 61);
            this.pagesName_label.TabIndex = 1;
            this.pagesName_label.Text = "History";
            // 
            // UC_HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 686);
            this.Controls.Add(this.pagesName_label);
            this.Name = "UC_HistoryPage";
            this.Size = new System.Drawing.Size(922, 686);
            this.Load += new System.EventHandler(this.UC_HistoryPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel pagesName_label;
        public Action<Quiz> OpenQuizHandler;
    }
}
