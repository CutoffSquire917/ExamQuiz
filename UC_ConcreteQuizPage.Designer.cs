using System;

namespace ExamQuiz
{
    partial class UC_ConcreteQuizPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ConcreteQuizPage));
            this.quizAuthor_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quizName_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.start_button = new Guna.UI2.WinForms.Guna2Button();
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).BeginInit();
            this.SuspendLayout();
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
            this.quizAuthor_label.Location = new System.Drawing.Point(70, 395);
            this.quizAuthor_label.Margin = new System.Windows.Forms.Padding(0);
            this.quizAuthor_label.Name = "quizAuthor_label";
            this.quizAuthor_label.Size = new System.Drawing.Size(415, 64);
            this.quizAuthor_label.TabIndex = 3;
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
            this.quizName_label.Location = new System.Drawing.Point(70, 350);
            this.quizName_label.Name = "quizName_label";
            this.quizName_label.Size = new System.Drawing.Size(415, 57);
            this.quizName_label.TabIndex = 2;
            this.quizName_label.Text = "Quiz name";
            // 
            // start_button
            // 
            this.start_button.Animated = true;
            this.start_button.BorderRadius = 15;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.start_button.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.start_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.start_button.Location = new System.Drawing.Point(623, 350);
            this.start_button.Name = "start_button";
            this.start_button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.start_button.Size = new System.Drawing.Size(229, 57);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "START!";
            this.start_button.Click += new System.EventHandler(this.start_quiz_Click);
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(40, 433);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Enabled = true;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.quiz_panel.Size = new System.Drawing.Size(822, 235);
            this.quiz_panel.TabIndex = 6;
            // 
            // quiz_image
            // 
            this.quiz_image.BackColor = System.Drawing.Color.Transparent;
            this.quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiz_image.BorderRadius = 15;
            this.quiz_image.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_image.Image = ((System.Drawing.Image)(resources.GetObject("quiz_image.Image")));
            this.quiz_image.ImageRotate = 0F;
            this.quiz_image.Location = new System.Drawing.Point(40, 20);
            this.quiz_image.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_image.Name = "quiz_image";
            this.quiz_image.ShadowDecoration.BorderRadius = 15;
            this.quiz_image.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.quiz_image.ShadowDecoration.Depth = 20;
            this.quiz_image.ShadowDecoration.Enabled = true;
            this.quiz_image.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20, 10, 20, 5);
            this.quiz_image.Size = new System.Drawing.Size(832, 320);
            this.quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quiz_image.TabIndex = 1;
            this.quiz_image.TabStop = false;
            // 
            // UC_ConcreteQuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.quiz_image);
            this.Controls.Add(this.quizAuthor_label);
            this.Controls.Add(this.quizName_label);
            this.Name = "UC_ConcreteQuizPage";
            this.Size = new System.Drawing.Size(922, 686);
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private Guna.UI2.WinForms.Guna2HtmlLabel quizAuthor_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel quizName_label;
        private Guna.UI2.WinForms.Guna2PictureBox quiz_image;
        private Guna.UI2.WinForms.Guna2Button start_button;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Quiz ConcreteQuiz;
        public event Action<Quiz> StartQuizHandler;

    }
}
