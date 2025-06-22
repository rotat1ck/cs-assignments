namespace client.forms.MainWindow
{
    partial class EmployeesForm
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
        private void InitializeComponent() {
            EmployeesLabel = new Label();
            collapsibleSidebar1 = new CollapsibleSidebar();
            EmployeesLayout = new TableLayoutPanel();
            NewEmployeeButton = new Button();
            EmployeeInfoLabel = new Label();
            EmployeeInfoLayout = new Panel();
            EmployeeAccountLayout = new Panel();
            EmployeeAccountLabel = new Label();
            EmployeeInfoSaveButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // EmployeesLabel
            // 
            EmployeesLabel.AutoSize = true;
            EmployeesLabel.BackColor = Color.Transparent;
            EmployeesLabel.Location = new Point(57, 9);
            EmployeesLabel.Name = "EmployeesLabel";
            EmployeesLabel.Size = new Size(121, 15);
            EmployeesLabel.TabIndex = 1;
            EmployeesLabel.Text = "Список сотрудников";
            // 
            // collapsibleSidebar1
            // 
            collapsibleSidebar1.AutoSize = false;
            collapsibleSidebar1.BackColor = Color.FromArgb(50, 50, 50);
            collapsibleSidebar1.Dock = DockStyle.Left;
            collapsibleSidebar1.ForeColor = Color.White;
            collapsibleSidebar1.ImageScalingSize = new Size(20, 20);
            collapsibleSidebar1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            collapsibleSidebar1.Location = new Point(0, 0);
            collapsibleSidebar1.Name = "collapsibleSidebar1";
            collapsibleSidebar1.Padding = new Padding(5, 2, 0, 2);
            collapsibleSidebar1.Size = new Size(54, 346);
            collapsibleSidebar1.TabIndex = 0;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // EmployeesLayout
            // 
            EmployeesLayout.BackColor = Color.Transparent;
            EmployeesLayout.ColumnCount = 2;
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.636364F));
            EmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            EmployeesLayout.Location = new Point(57, 29);
            EmployeesLayout.Name = "EmployeesLayout";
            EmployeesLayout.RowCount = 1;
            EmployeesLayout.RowStyles.Add(new RowStyle());
            EmployeesLayout.Size = new Size(265, 305);
            EmployeesLayout.TabIndex = 2;
            // 
            // NewEmployeeButton
            // 
            NewEmployeeButton.Location = new Point(182, 4);
            NewEmployeeButton.Name = "NewEmployeeButton";
            NewEmployeeButton.Size = new Size(140, 24);
            NewEmployeeButton.TabIndex = 3;
            NewEmployeeButton.Text = "Добавить сотрудника";
            NewEmployeeButton.UseVisualStyleBackColor = true;
            NewEmployeeButton.Click += NewEmployeeButton_Click;
            // 
            // EmployeeInfoLabel
            // 
            EmployeeInfoLabel.AutoSize = true;
            EmployeeInfoLabel.BackColor = Color.Transparent;
            EmployeeInfoLabel.Location = new Point(348, 9);
            EmployeeInfoLabel.Name = "EmployeeInfoLabel";
            EmployeeInfoLabel.Size = new Size(157, 15);
            EmployeeInfoLabel.TabIndex = 4;
            EmployeeInfoLabel.Text = "Информация о сотруднике";
            EmployeeInfoLabel.Visible = false;
            // 
            // EmployeeInfoLayout
            // 
            EmployeeInfoLayout.BackColor = Color.Transparent;
            EmployeeInfoLayout.Location = new Point(348, 29);
            EmployeeInfoLayout.Name = "EmployeeInfoLayout";
            EmployeeInfoLayout.Size = new Size(235, 136);
            EmployeeInfoLayout.TabIndex = 5;
            EmployeeInfoLayout.Visible = false;
            // 
            // EmployeeAccountLayout
            // 
            EmployeeAccountLayout.BackColor = Color.Transparent;
            EmployeeAccountLayout.Location = new Point(348, 215);
            EmployeeAccountLayout.Name = "EmployeeAccountLayout";
            EmployeeAccountLayout.Size = new Size(235, 90);
            EmployeeAccountLayout.TabIndex = 7;
            EmployeeAccountLayout.Visible = false;
            // 
            // EmployeeAccountLabel
            // 
            EmployeeAccountLabel.AutoSize = true;
            EmployeeAccountLabel.BackColor = Color.Transparent;
            EmployeeAccountLabel.Location = new Point(348, 197);
            EmployeeAccountLabel.Name = "EmployeeAccountLabel";
            EmployeeAccountLabel.Size = new Size(187, 15);
            EmployeeAccountLabel.TabIndex = 6;
            EmployeeAccountLabel.Text = "Информация об учетной записи";
            EmployeeAccountLabel.Visible = false;
            // 
            // EmployeeInfoSaveButton
            // 
            EmployeeInfoSaveButton.Location = new Point(348, 171);
            EmployeeInfoSaveButton.Name = "EmployeeInfoSaveButton";
            EmployeeInfoSaveButton.Size = new Size(235, 23);
            EmployeeInfoSaveButton.TabIndex = 8;
            EmployeeInfoSaveButton.Text = "Сохранить изменения";
            EmployeeInfoSaveButton.UseVisualStyleBackColor = true;
            EmployeeInfoSaveButton.Visible = false;
            EmployeeInfoSaveButton.Click += EmployeeInfoSaveButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(490, 311);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 9;
            button1.Text = "Сброс пароля";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(348, 311);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 10;
            button2.Text = "Сохранить изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 346);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EmployeeInfoSaveButton);
            Controls.Add(EmployeeAccountLayout);
            Controls.Add(EmployeeAccountLabel);
            Controls.Add(EmployeeInfoLayout);
            Controls.Add(EmployeeInfoLabel);
            Controls.Add(NewEmployeeButton);
            Controls.Add(EmployeesLayout);
            Controls.Add(EmployeesLabel);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(614, 385);
            MinimizeBox = false;
            MinimumSize = new Size(614, 385);
            Name = "EmployeesForm";
            Text = "Управление сотрудниками";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmployeesLabel;
        private CollapsibleSidebar collapsibleSidebar1;
        private TableLayoutPanel EmployeesLayout;
        private Button NewEmployeeButton;
        private Label EmployeeInfoLabel;
        private Panel EmployeeInfoLayout;
        private Panel EmployeeAccountLayout;
        private Label EmployeeAccountLabel;
        private Button EmployeeInfoSaveButton;
        private Button button1;
        private Button button2;
    }
}