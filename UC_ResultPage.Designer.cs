using System;

namespace ExamQuiz
{
    partial class UC_ResultPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ResultPage));
            this.quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.result_progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.scoreInPercentage_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.scoreInPoints_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.score_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizAuthor_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tryAgain_button = new Guna.UI2.WinForms.Guna2Button();
            this.quit_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).BeginInit();
            this.quiz_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quiz_image
            // 
            this.quiz_image.BackColor = System.Drawing.Color.Transparent;
            this.quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiz_image.BorderRadius = 15;
            this.quiz_image.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_image.Image = ((System.Drawing.Image)(resources.GetObject("quiz_image.Image")));
            this.quiz_image.ImageRotate = 0F;
            this.quiz_image.Location = new System.Drawing.Point(266, 80);
            this.quiz_image.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_image.Name = "quiz_image";
            this.quiz_image.ShadowDecoration.BorderRadius = 15;
            this.quiz_image.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.quiz_image.ShadowDecoration.Depth = 20;
            this.quiz_image.ShadowDecoration.Enabled = true;
            this.quiz_image.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.quiz_image.Size = new System.Drawing.Size(968, 320);
            this.quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quiz_image.TabIndex = 2;
            this.quiz_image.TabStop = false;
            // 
            // result_progressBar
            // 
            this.result_progressBar.AutoRoundedCorners = true;
            this.result_progressBar.BackColor = System.Drawing.Color.Transparent;
            this.result_progressBar.BorderColor = System.Drawing.Color.DarkGray;
            this.result_progressBar.BorderRadius = 19;
            this.result_progressBar.BorderThickness = 2;
            this.result_progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.result_progressBar.Font = new System.Drawing.Font("Cambria Math", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_progressBar.ForeColor = System.Drawing.Color.White;
            this.result_progressBar.Location = new System.Drawing.Point(266, 420);
            this.result_progressBar.Name = "result_progressBar";
            this.result_progressBar.ProgressColor = System.Drawing.Color.LawnGreen;
            this.result_progressBar.ProgressColor2 = System.Drawing.Color.YellowGreen;
            this.result_progressBar.ShowText = true;
            this.result_progressBar.Size = new System.Drawing.Size(968, 40);
            this.result_progressBar.TabIndex = 3;
            this.result_progressBar.Text = "50.0 %";
            this.result_progressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result_progressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.result_progressBar.TextOffset = new System.Drawing.Point(-20, 3);
            this.result_progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.result_progressBar.Value = 50;
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Controls.Add(this.scoreInPercentage_label);
            this.quiz_panel.Controls.Add(this.scoreInPoints_label);
            this.quiz_panel.Controls.Add(this.score_label);
            this.quiz_panel.Controls.Add(this.quizAuthor_label);
            this.quiz_panel.Controls.Add(this.quizName_label);
            this.quiz_panel.Controls.Add(this.tryAgain_button);
            this.quiz_panel.Controls.Add(this.quit_button);
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(266, 480);
            this.quiz_panel.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.quiz_panel.Size = new System.Drawing.Size(968, 231);
            this.quiz_panel.TabIndex = 8;
            // 
            // scoreInPercentage_label
            // 
            this.scoreInPercentage_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreInPercentage_label.AutoSize = false;
            this.scoreInPercentage_label.BackColor = System.Drawing.Color.Transparent;
            this.scoreInPercentage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreInPercentage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scoreInPercentage_label.Location = new System.Drawing.Point(641, 55);
            this.scoreInPercentage_label.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.scoreInPercentage_label.Name = "scoreInPercentage_label";
            this.scoreInPercentage_label.Size = new System.Drawing.Size(321, 57);
            this.scoreInPercentage_label.TabIndex = 16;
            this.scoreInPercentage_label.Text = "100.0 / 100.0 %";
            // 
            // scoreInPoints_label
            // 
            this.scoreInPoints_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreInPoints_label.AutoSize = false;
            this.scoreInPoints_label.BackColor = System.Drawing.Color.Transparent;
            this.scoreInPoints_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreInPoints_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.scoreInPoints_label.Location = new System.Drawing.Point(641, 10);
            this.scoreInPoints_label.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.scoreInPoints_label.Name = "scoreInPoints_label";
            this.scoreInPoints_label.Size = new System.Drawing.Size(327, 57);
            this.scoreInPoints_label.TabIndex = 15;
            this.scoreInPoints_label.Text = "10 / 10";
            // 
            // score_label
            // 
            this.score_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.score_label.AutoSize = false;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.score_label.Location = new System.Drawing.Point(483, 10);
            this.score_label.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(162, 57);
            this.score_label.TabIndex = 14;
            this.score_label.Text = "Score: ";
            // 
            // quizAuthor_label
            // 
            this.quizAuthor_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizAuthor_label.AutoSize = false;
            this.quizAuthor_label.BackColor = System.Drawing.Color.Transparent;
            this.quizAuthor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizAuthor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.quizAuthor_label.Location = new System.Drawing.Point(60, 55);
            this.quizAuthor_label.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.quizAuthor_label.Name = "quizAuthor_label";
            this.quizAuthor_label.Size = new System.Drawing.Size(415, 64);
            this.quizAuthor_label.TabIndex = 13;
            this.quizAuthor_label.Text = "quizAuthor_label";
            // 
            // quizName_label
            // 
            this.quizName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizName_label.AutoSize = false;
            this.quizName_label.BackColor = System.Drawing.Color.Transparent;
            this.quizName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.quizName_label.Location = new System.Drawing.Point(60, 10);
            this.quizName_label.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.quizName_label.Name = "quizName_label";
            this.quizName_label.Size = new System.Drawing.Size(415, 57);
            this.quizName_label.TabIndex = 12;
            this.quizName_label.Text = "Quiz name";
            // 
            // tryAgain_button
            // 
            this.tryAgain_button.Animated = true;
            this.tryAgain_button.AutoRoundedCorners = true;
            this.tryAgain_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.tryAgain_button.BorderThickness = 2;
            this.tryAgain_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tryAgain_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tryAgain_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tryAgain_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tryAgain_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tryAgain_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.tryAgain_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryAgain_button.ForeColor = System.Drawing.Color.White;
            this.tryAgain_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.tryAgain_button.Location = new System.Drawing.Point(725, 150);
            this.tryAgain_button.Name = "tryAgain_button";
            this.tryAgain_button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.tryAgain_button.Size = new System.Drawing.Size(173, 61);
            this.tryAgain_button.TabIndex = 11;
            this.tryAgain_button.Text = "Try again";
            this.tryAgain_button.Click += new System.EventHandler(this.tryAgain_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.Animated = true;
            this.quit_button.AutoRoundedCorners = true;
            this.quit_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quit_button.BorderThickness = 2;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quit_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quit_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.quit_button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quit_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.Location = new System.Drawing.Point(70, 150);
            this.quit_button.Name = "quit_button";
            this.quit_button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.Size = new System.Drawing.Size(173, 61);
            this.quit_button.TabIndex = 10;
            this.quit_button.Text = "Quit";
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // UC_ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.result_progressBar);
            this.Controls.Add(this.quiz_image);
            this.Name = "UC_ResultPage";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.UC_ResultPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).EndInit();
            this.quiz_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox quiz_image;
        private Guna.UI2.WinForms.Guna2ProgressBar result_progressBar;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Guna.UI2.WinForms.Guna2Button tryAgain_button;
        private Guna.UI2.WinForms.Guna2Button quit_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel score_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizAuthor_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizName_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel scoreInPercentage_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel scoreInPoints_label;
        public Action QuizCloseHandler;
        private Quiz ResultQuiz;
        private bool[] Results;
    }
}
