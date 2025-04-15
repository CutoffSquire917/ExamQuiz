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
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.resultBar_progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.result_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.quiz_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pagesName_label
            // 
            this.pagesName_label.AutoSize = false;
            this.pagesName_label.BackColor = System.Drawing.Color.Transparent;
            this.pagesName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.pagesName_label.Location = new System.Drawing.Point(50, 20);
            this.pagesName_label.Name = "pagesName_label";
            this.pagesName_label.Size = new System.Drawing.Size(261, 88);
            this.pagesName_label.TabIndex = 1;
            this.pagesName_label.Text = "History";
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Controls.Add(this.resultBar_progressBar);
            this.quiz_panel.Controls.Add(this.result_label);
            this.quiz_panel.Controls.Add(this.date_label);
            this.quiz_panel.Controls.Add(this.quizName_label);
            this.quiz_panel.Controls.Add(this.quiz_image);
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(50, 102);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Enabled = true;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.quiz_panel.Size = new System.Drawing.Size(822, 95);
            this.quiz_panel.TabIndex = 3;
            // 
            // resultBar_progressBar
            // 
            this.resultBar_progressBar.Backwards = true;
            this.resultBar_progressBar.EnsureVisible = true;
            this.resultBar_progressBar.FillColor = System.Drawing.Color.Red;
            this.resultBar_progressBar.FillThickness = 7;
            this.resultBar_progressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resultBar_progressBar.ForeColor = System.Drawing.Color.White;
            this.resultBar_progressBar.Location = new System.Drawing.Point(727, 31);
            this.resultBar_progressBar.Minimum = 0;
            this.resultBar_progressBar.Name = "resultBar_progressBar";
            this.resultBar_progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.resultBar_progressBar.ProgressColor = System.Drawing.Color.Lime;
            this.resultBar_progressBar.ProgressColor2 = System.Drawing.Color.Lime;
            this.resultBar_progressBar.ProgressThickness = 8;
            this.resultBar_progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultBar_progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.resultBar_progressBar.Size = new System.Drawing.Size(35, 35);
            this.resultBar_progressBar.TabIndex = 4;
            this.resultBar_progressBar.Value = 30;
            // 
            // result_label
            // 
            this.result_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_label.AutoSize = false;
            this.result_label.BackColor = System.Drawing.Color.Transparent;
            this.result_label.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.result_label.Location = new System.Drawing.Point(602, 33);
            this.result_label.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(187, 44);
            this.result_label.TabIndex = 4;
            this.result_label.Text = "10.9 %";
            this.result_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.AutoSize = false;
            this.date_label.BackColor = System.Drawing.Color.Transparent;
            this.date_label.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.date_label.Location = new System.Drawing.Point(635, 71);
            this.date_label.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(187, 24);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "12.34.5678";
            this.date_label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quizName_label
            // 
            this.quizName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizName_label.BackColor = System.Drawing.Color.Transparent;
            this.quizName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.quizName_label.Location = new System.Drawing.Point(331, 29);
            this.quizName_label.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.quizName_label.Name = "quizName_label";
            this.quizName_label.Size = new System.Drawing.Size(144, 38);
            this.quizName_label.TabIndex = 2;
            this.quizName_label.Text = "Quiz name";
            this.quizName_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quiz_image
            // 
            this.quiz_image.BackColor = System.Drawing.Color.Transparent;
            this.quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiz_image.BorderRadius = 30;
            this.quiz_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.quiz_image.Image = global::ExamQuiz.Properties.Resources.default_image;
            this.quiz_image.ImageRotate = 0F;
            this.quiz_image.Location = new System.Drawing.Point(0, 0);
            this.quiz_image.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_image.Name = "quiz_image";
            this.quiz_image.ShadowDecoration.BorderRadius = 30;
            this.quiz_image.ShadowDecoration.Depth = 10;
            this.quiz_image.Size = new System.Drawing.Size(311, 95);
            this.quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quiz_image.TabIndex = 1;
            this.quiz_image.TabStop = false;
            // 
            // UC_HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.pagesName_label);
            this.Name = "UC_HistoryPage";
            this.Size = new System.Drawing.Size(922, 686);
            this.Load += new System.EventHandler(this.UC_HistoryPage_Load);
            this.quiz_panel.ResumeLayout(false);
            this.quiz_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel pagesName_label;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizName_label;
        private Guna.UI2.WinForms.Guna2PictureBox quiz_image;
        private Guna.UI2.WinForms.Guna2HtmlLabel date_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel result_label;
        private Guna.UI2.WinForms.Guna2CircleProgressBar resultBar_progressBar;
    }
}
