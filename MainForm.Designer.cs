namespace ExamQuiz
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drag_panel = new System.Windows.Forms.Panel();
            this.hide_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.drag_control = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pages_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.close2_button = new Guna.UI2.WinForms.Guna2Button();
            this.nameChil_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.settings_button = new Guna.UI2.WinForms.Guna2Button();
            this.created_button = new Guna.UI2.WinForms.Guna2Button();
            this.history_button = new Guna.UI2.WinForms.Guna2Button();
            this.quizzes_button = new Guna.UI2.WinForms.Guna2Button();
            this.nameQuiz_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.page_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.quizzes_page = new ExamQuiz.UC_QuizzesPage();
            this.settings_page = new ExamQuiz.UC_SettingsPage();
            this.created_page = new ExamQuiz.UC_CreatedPage();
            this.history_page = new ExamQuiz.UC_HistoryPage();
            this.concreteQuiz_page = new ExamQuiz.UC_ConcreteQuizPage();
            this.drag_panel.SuspendLayout();
            this.pages_panel.SuspendLayout();
            this.page_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.drag_panel.Controls.Add(this.hide_button);
            this.drag_panel.Controls.Add(this.close_button);
            this.drag_panel.Location = new System.Drawing.Point(280, 0);
            this.drag_panel.Margin = new System.Windows.Forms.Padding(0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(922, 34);
            this.drag_panel.TabIndex = 1;
            // 
            // hide_button
            // 
            this.hide_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide_button.Animated = true;
            this.hide_button.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.hide_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.hide_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hide_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.hide_button.Location = new System.Drawing.Point(802, 0);
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
            this.close_button.Location = new System.Drawing.Point(862, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(60, 31);
            this.close_button.TabIndex = 0;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // drag_control
            // 
            this.drag_control.DockIndicatorTransparencyValue = 0.6D;
            this.drag_control.TargetControl = this.drag_panel;
            this.drag_control.UseTransparentDrag = true;
            // 
            // pages_panel
            // 
            this.pages_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pages_panel.Controls.Add(this.close2_button);
            this.pages_panel.Controls.Add(this.nameChil_label);
            this.pages_panel.Controls.Add(this.settings_button);
            this.pages_panel.Controls.Add(this.created_button);
            this.pages_panel.Controls.Add(this.history_button);
            this.pages_panel.Controls.Add(this.quizzes_button);
            this.pages_panel.Controls.Add(this.nameQuiz_label);
            this.pages_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pages_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pages_panel.Location = new System.Drawing.Point(0, 0);
            this.pages_panel.Margin = new System.Windows.Forms.Padding(0);
            this.pages_panel.Name = "pages_panel";
            this.pages_panel.ShadowDecoration.Depth = 5;
            this.pages_panel.ShadowDecoration.Enabled = true;
            this.pages_panel.Size = new System.Drawing.Size(274, 720);
            this.pages_panel.TabIndex = 2;
            // 
            // close2_button
            // 
            this.close2_button.BackColor = System.Drawing.SystemColors.Window;
            this.close2_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.close2_button.BorderRadius = 15;
            this.close2_button.BorderThickness = 1;
            this.close2_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close2_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close2_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close2_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close2_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.close2_button.Font = new System.Drawing.Font("Sans Serif Collection", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.close2_button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.close2_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.close2_button.Location = new System.Drawing.Point(59, 651);
            this.close2_button.Name = "close2_button";
            this.close2_button.Size = new System.Drawing.Size(150, 48);
            this.close2_button.TabIndex = 4;
            this.close2_button.Text = "EXIT";
            this.close2_button.TextOffset = new System.Drawing.Point(0, 2);
            this.close2_button.Click += new System.EventHandler(this.close2_button_Click);
            // 
            // nameChil_label
            // 
            this.nameChil_label.AutoSize = false;
            this.nameChil_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameChil_label.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChil_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.nameChil_label.Location = new System.Drawing.Point(36, 34);
            this.nameChil_label.Margin = new System.Windows.Forms.Padding(0);
            this.nameChil_label.Name = "nameChil_label";
            this.nameChil_label.Size = new System.Drawing.Size(189, 61);
            this.nameChil_label.TabIndex = 7;
            this.nameChil_label.Text = "Chill";
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settings_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settings_button.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.settings_button.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.settings_button.CheckedState.Image = global::ExamQuiz.Properties.Resources.Settings_selected;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.settings_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.settings_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settings_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settings_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settings_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settings_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.settings_button.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.Color.Black;
            this.settings_button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.settings_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.settings_button.HoverState.Image = global::ExamQuiz.Properties.Resources.Settings;
            this.settings_button.Image = global::ExamQuiz.Properties.Resources.Settings;
            this.settings_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settings_button.ImageOffset = new System.Drawing.Point(17, 0);
            this.settings_button.ImageSize = new System.Drawing.Size(22, 22);
            this.settings_button.Location = new System.Drawing.Point(0, 370);
            this.settings_button.Margin = new System.Windows.Forms.Padding(0);
            this.settings_button.Name = "settings_button";
            this.settings_button.PressedDepth = 0;
            this.settings_button.Size = new System.Drawing.Size(274, 58);
            this.settings_button.TabIndex = 6;
            this.settings_button.Text = "Settings";
            this.settings_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settings_button.TextOffset = new System.Drawing.Point(24, 3);
            this.settings_button.CheckedChanged += new System.EventHandler(this.settings_button_CheckedChanged);
            // 
            // created_button
            // 
            this.created_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.created_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.created_button.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.created_button.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.created_button.CheckedState.Image = global::ExamQuiz.Properties.Resources.Created_selected;
            this.created_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.created_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.created_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.created_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.created_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.created_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.created_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.created_button.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_button.ForeColor = System.Drawing.Color.Black;
            this.created_button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.created_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.created_button.HoverState.Image = global::ExamQuiz.Properties.Resources.Created;
            this.created_button.Image = global::ExamQuiz.Properties.Resources.Created;
            this.created_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.created_button.ImageOffset = new System.Drawing.Point(17, 0);
            this.created_button.ImageSize = new System.Drawing.Size(22, 22);
            this.created_button.Location = new System.Drawing.Point(0, 312);
            this.created_button.Margin = new System.Windows.Forms.Padding(0);
            this.created_button.Name = "created_button";
            this.created_button.PressedDepth = 0;
            this.created_button.Size = new System.Drawing.Size(274, 58);
            this.created_button.TabIndex = 5;
            this.created_button.Text = "My  quizzes";
            this.created_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.created_button.TextOffset = new System.Drawing.Point(24, 3);
            this.created_button.CheckedChanged += new System.EventHandler(this.created_button_CheckedChanged);
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.history_button.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.history_button.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.history_button.CheckedState.Image = global::ExamQuiz.Properties.Resources.History_selected;
            this.history_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.history_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.history_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.history_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.history_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.history_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.history_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.history_button.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.ForeColor = System.Drawing.Color.Black;
            this.history_button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.history_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.history_button.HoverState.Image = global::ExamQuiz.Properties.Resources.History;
            this.history_button.Image = global::ExamQuiz.Properties.Resources.History;
            this.history_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.history_button.ImageOffset = new System.Drawing.Point(15, 0);
            this.history_button.ImageSize = new System.Drawing.Size(26, 22);
            this.history_button.Location = new System.Drawing.Point(0, 254);
            this.history_button.Margin = new System.Windows.Forms.Padding(0);
            this.history_button.Name = "history_button";
            this.history_button.PressedDepth = 0;
            this.history_button.Size = new System.Drawing.Size(274, 58);
            this.history_button.TabIndex = 4;
            this.history_button.Text = "History";
            this.history_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.history_button.TextOffset = new System.Drawing.Point(20, 3);
            this.history_button.CheckedChanged += new System.EventHandler(this.history_button_CheckedChanged);
            // 
            // quizzes_button
            // 
            this.quizzes_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quizzes_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.quizzes_button.Checked = true;
            this.quizzes_button.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.quizzes_button.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quizzes_button.CheckedState.Image = global::ExamQuiz.Properties.Resources.Home_selected;
            this.quizzes_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.quizzes_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.quizzes_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quizzes_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quizzes_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quizzes_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quizzes_button.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quizzes_button.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizzes_button.ForeColor = System.Drawing.Color.Black;
            this.quizzes_button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.quizzes_button.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quizzes_button.HoverState.Image = global::ExamQuiz.Properties.Resources.Home;
            this.quizzes_button.Image = global::ExamQuiz.Properties.Resources.Home;
            this.quizzes_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quizzes_button.ImageOffset = new System.Drawing.Point(15, 0);
            this.quizzes_button.ImageSize = new System.Drawing.Size(26, 22);
            this.quizzes_button.Location = new System.Drawing.Point(0, 196);
            this.quizzes_button.Margin = new System.Windows.Forms.Padding(0);
            this.quizzes_button.Name = "quizzes_button";
            this.quizzes_button.PressedDepth = 0;
            this.quizzes_button.Size = new System.Drawing.Size(274, 58);
            this.quizzes_button.TabIndex = 3;
            this.quizzes_button.Text = "Quizzes";
            this.quizzes_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quizzes_button.TextOffset = new System.Drawing.Point(20, 3);
            this.quizzes_button.CheckedChanged += new System.EventHandler(this.quizzes_button_CheckedChanged);
            // 
            // nameQuiz_label
            // 
            this.nameQuiz_label.AutoSize = false;
            this.nameQuiz_label.BackColor = System.Drawing.Color.Transparent;
            this.nameQuiz_label.Font = new System.Drawing.Font("Gabriola", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameQuiz_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nameQuiz_label.Location = new System.Drawing.Point(87, 63);
            this.nameQuiz_label.Margin = new System.Windows.Forms.Padding(0);
            this.nameQuiz_label.Name = "nameQuiz_label";
            this.nameQuiz_label.Size = new System.Drawing.Size(138, 112);
            this.nameQuiz_label.TabIndex = 8;
            this.nameQuiz_label.Text = "Quiz";
            // 
            // page_panel
            // 
            this.page_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page_panel.Controls.Add(this.quizzes_page);
            this.page_panel.Controls.Add(this.settings_page);
            this.page_panel.Controls.Add(this.created_page);
            this.page_panel.Controls.Add(this.history_page);
            this.page_panel.Controls.Add(this.concreteQuiz_page);
            this.page_panel.Location = new System.Drawing.Point(280, 34);
            this.page_panel.Margin = new System.Windows.Forms.Padding(0);
            this.page_panel.Name = "page_panel";
            this.page_panel.Size = new System.Drawing.Size(922, 686);
            this.page_panel.TabIndex = 3;
            // 
            // quizzes_page
            // 
            this.quizzes_page.AutoScroll = true;
            this.quizzes_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizzes_page.Location = new System.Drawing.Point(0, 0);
            this.quizzes_page.Name = "quizzes_page";
            this.quizzes_page.Size = new System.Drawing.Size(922, 686);
            this.quizzes_page.TabIndex = 0;
            // 
            // settings_page
            // 
            this.settings_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_page.Location = new System.Drawing.Point(0, 0);
            this.settings_page.Name = "settings_page";
            this.settings_page.Size = new System.Drawing.Size(922, 686);
            this.settings_page.TabIndex = 3;
            // 
            // created_page
            // 
            this.created_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.created_page.Location = new System.Drawing.Point(0, 0);
            this.created_page.Name = "created_page";
            this.created_page.Size = new System.Drawing.Size(922, 686);
            this.created_page.TabIndex = 2;
            // 
            // history_page
            // 
            this.history_page.AutoScroll = true;
            this.history_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_page.Location = new System.Drawing.Point(0, 0);
            this.history_page.Name = "history_page";
            this.history_page.Size = new System.Drawing.Size(922, 686);
            this.history_page.TabIndex = 1;
            // 
            // concreteQuiz_page
            // 
            this.concreteQuiz_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concreteQuiz_page.Location = new System.Drawing.Point(0, 0);
            this.concreteQuiz_page.Name = "concreteQuiz_page";
            this.concreteQuiz_page.Size = new System.Drawing.Size(922, 686);
            this.concreteQuiz_page.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.page_panel);
            this.Controls.Add(this.pages_panel);
            this.Controls.Add(this.drag_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chill Quiz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.drag_panel.ResumeLayout(false);
            this.pages_panel.ResumeLayout(false);
            this.page_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel drag_panel;
        private Guna.UI2.WinForms.Guna2DragControl drag_control;
        private Guna.UI2.WinForms.Guna2ControlBox hide_button;
        private Guna.UI2.WinForms.Guna2ControlBox close_button;
        private Guna.UI2.WinForms.Guna2Panel pages_panel;
        private Guna.UI2.WinForms.Guna2Button quizzes_button;
        private Guna.UI2.WinForms.Guna2Button settings_button;
        private Guna.UI2.WinForms.Guna2Button created_button;
        private Guna.UI2.WinForms.Guna2Button history_button;
        private Guna.UI2.WinForms.Guna2Panel page_panel;
        private UC_QuizzesPage quizzes_page;
        private UC_SettingsPage settings_page;
        private UC_CreatedPage created_page;
        private UC_HistoryPage history_page;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameChil_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameQuiz_label;
        private Guna.UI2.WinForms.Guna2Button close2_button;
        private UC_ConcreteQuizPage concreteQuiz_page;

    }
}

