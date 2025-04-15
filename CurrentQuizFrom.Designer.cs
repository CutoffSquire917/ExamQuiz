using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ExamQuiz
{
    partial class CurrentQuizFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.hide_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.info_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.quit_button = new Guna.UI2.WinForms.Guna2Button();
            this.finish_button = new Guna.UI2.WinForms.Guna2Button();
            this.numberOf_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quiz_image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.quiz_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.quistion_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.drag_control = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.answers_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.check_button = new Guna.UI2.WinForms.Guna2Button();
            this.drag_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).BeginInit();
            this.quiz_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.drag_panel.Controls.Add(this.hide_button);
            this.drag_panel.Controls.Add(this.close_button);
            this.drag_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drag_panel.Location = new System.Drawing.Point(0, 0);
            this.drag_panel.Margin = new System.Windows.Forms.Padding(0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(1200, 34);
            this.drag_panel.TabIndex = 2;
            // 
            // hide_button
            // 
            this.hide_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide_button.Animated = true;
            this.hide_button.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.hide_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.hide_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hide_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.hide_button.Location = new System.Drawing.Point(1080, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(60, 31);
            this.hide_button.TabIndex = 1;
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.Animated = true;
            this.close_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.close_button.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.close_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.close_button.Location = new System.Drawing.Point(1140, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(60, 31);
            this.close_button.TabIndex = 0;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // info_panel
            // 
            this.info_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_panel.BackColor = System.Drawing.Color.Transparent;
            this.info_panel.BorderRadius = 15;
            this.info_panel.Controls.Add(this.quit_button);
            this.info_panel.Controls.Add(this.finish_button);
            this.info_panel.Controls.Add(this.numberOf_label);
            this.info_panel.Controls.Add(this.quiz_image);
            this.info_panel.Location = new System.Drawing.Point(29, 44);
            this.info_panel.Margin = new System.Windows.Forms.Padding(20, 10, 30, 10);
            this.info_panel.Name = "info_panel";
            this.info_panel.ShadowDecoration.BorderRadius = 15;
            this.info_panel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.info_panel.ShadowDecoration.Depth = 50;
            this.info_panel.ShadowDecoration.Enabled = true;
            this.info_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.info_panel.Size = new System.Drawing.Size(1132, 68);
            this.info_panel.TabIndex = 4;
            // 
            // quit_button
            // 
            this.quit_button.Animated = true;
            this.quit_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.quit_button.BorderRadius = 20;
            this.quit_button.BorderThickness = 1;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quit_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.quit_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit_button.ForeColor = System.Drawing.Color.Gray;
            this.quit_button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.quit_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.Location = new System.Drawing.Point(180, 9);
            this.quit_button.Name = "quit_button";
            this.quit_button.PressedColor = System.Drawing.Color.White;
            this.quit_button.Size = new System.Drawing.Size(126, 50);
            this.quit_button.TabIndex = 23;
            this.quit_button.Text = "quit";
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // finish_button
            // 
            this.finish_button.Animated = true;
            this.finish_button.BorderRadius = 20;
            this.finish_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finish_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.finish_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.finish_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.finish_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.finish_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.finish_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finish_button.ForeColor = System.Drawing.Color.Gray;
            this.finish_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.finish_button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.finish_button.Location = new System.Drawing.Point(958, 9);
            this.finish_button.Name = "finish_button";
            this.finish_button.PressedColor = System.Drawing.Color.White;
            this.finish_button.Size = new System.Drawing.Size(153, 50);
            this.finish_button.TabIndex = 22;
            this.finish_button.Text = "finish";
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // numberOf_label
            // 
            this.numberOf_label.BackColor = System.Drawing.Color.Transparent;
            this.numberOf_label.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOf_label.ForeColor = System.Drawing.Color.White;
            this.numberOf_label.Location = new System.Drawing.Point(808, 17);
            this.numberOf_label.Name = "numberOf_label";
            this.numberOf_label.Size = new System.Drawing.Size(97, 34);
            this.numberOf_label.TabIndex = 4;
            this.numberOf_label.Text = "1 / 10";
            // 
            // quiz_image
            // 
            this.quiz_image.BackColor = System.Drawing.Color.Transparent;
            this.quiz_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiz_image.BorderRadius = 15;
            this.quiz_image.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.quiz_image.Image = global::ExamQuiz.Properties.Resources.default_image;
            this.quiz_image.ImageRotate = 0F;
            this.quiz_image.Location = new System.Drawing.Point(0, 0);
            this.quiz_image.Margin = new System.Windows.Forms.Padding(0);
            this.quiz_image.Name = "quiz_image";
            this.quiz_image.ShadowDecoration.BorderRadius = 20;
            this.quiz_image.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.quiz_image.ShadowDecoration.Depth = 40;
            this.quiz_image.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.quiz_image.Size = new System.Drawing.Size(161, 68);
            this.quiz_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quiz_image.TabIndex = 3;
            this.quiz_image.TabStop = false;
            // 
            // quiz_panel
            // 
            this.quiz_panel.BackColor = System.Drawing.Color.Transparent;
            this.quiz_panel.BorderRadius = 30;
            this.quiz_panel.Controls.Add(this.quistion_label);
            this.quiz_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.quiz_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quiz_panel.Location = new System.Drawing.Point(29, 132);
            this.quiz_panel.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.quiz_panel.Name = "quiz_panel";
            this.quiz_panel.ShadowDecoration.BorderRadius = 30;
            this.quiz_panel.ShadowDecoration.Depth = 5;
            this.quiz_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.quiz_panel.Size = new System.Drawing.Size(1142, 231);
            this.quiz_panel.TabIndex = 7;
            // 
            // quistion_label
            // 
            this.quistion_label.AutoSize = false;
            this.quistion_label.BackColor = System.Drawing.Color.Transparent;
            this.quistion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quistion_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.quistion_label.Location = new System.Drawing.Point(50, 0);
            this.quistion_label.Margin = new System.Windows.Forms.Padding(0);
            this.quistion_label.MaximumSize = new System.Drawing.Size(1042, 0);
            this.quistion_label.Name = "quistion_label";
            this.quistion_label.Size = new System.Drawing.Size(1042, 231);
            this.quistion_label.TabIndex = 9;
            this.quistion_label.Text = "Question";
            this.quistion_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drag_control
            // 
            this.drag_control.DockIndicatorTransparencyValue = 0.6D;
            this.drag_control.TargetControl = this.drag_panel;
            this.drag_control.UseTransparentDrag = true;
            // 
            // answers_panel
            // 
            this.answers_panel.Location = new System.Drawing.Point(27, 376);
            this.answers_panel.Name = "answers_panel";
            this.answers_panel.Size = new System.Drawing.Size(1142, 250);
            this.answers_panel.TabIndex = 21;
            // 
            // check_button
            // 
            this.check_button.Animated = true;
            this.check_button.BorderRadius = 20;
            this.check_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.check_button.FillColor = System.Drawing.Color.Silver;
            this.check_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_button.ForeColor = System.Drawing.Color.White;
            this.check_button.HoverState.FillColor = System.Drawing.Color.Silver;
            this.check_button.Location = new System.Drawing.Point(961, 642);
            this.check_button.Name = "check_button";
            this.check_button.PressedColor = System.Drawing.Color.Silver;
            this.check_button.Size = new System.Drawing.Size(179, 62);
            this.check_button.TabIndex = 12;
            this.check_button.Text = "Check";
            this.check_button.Visible = false;
            // 
            // CurrentQuizFrom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.answers_panel);
            this.Controls.Add(this.quiz_panel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.drag_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentQuizFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentQuizFrom";
            this.Load += new System.EventHandler(this.CurrentQuizFrom_Load);
            this.drag_panel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_image)).EndInit();
            this.quiz_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drag_panel;
        private Guna.UI2.WinForms.Guna2ControlBox hide_button;
        private Guna.UI2.WinForms.Guna2ControlBox close_button;
        private Guna.UI2.WinForms.Guna2PictureBox quiz_image;
        private Guna.UI2.WinForms.Guna2Panel info_panel;
        private Guna.UI2.WinForms.Guna2Panel quiz_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel quistion_label;
        private Guna.UI2.WinForms.Guna2DragControl drag_control;
        private Guna.UI2.WinForms.Guna2Panel answers_panel;
        private Guna.UI2.WinForms.Guna2Button check_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel numberOf_label;
        private Guna.UI2.WinForms.Guna2Button finish_button;
        private Guna.UI2.WinForms.Guna2Button quit_button;
        private Quiz CurrentQuiz;
        private Action IsTrueAnswer;
        private bool[] Results;
        private int Index = 0;
        private List<Guna.UI2.WinForms.Guna2Button> Pressed = new List<Guna.UI2.WinForms.Guna2Button>();
    }
}