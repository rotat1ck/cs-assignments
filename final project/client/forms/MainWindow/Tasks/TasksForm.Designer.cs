namespace client.forms.MainWindow
{
    partial class TasksForm
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
            collapsibleSidebar1 = new CollapsibleSidebar();
            TasksLabel = new Label();
            TasksLayout = new TableLayoutPanel();
            NewTaskButton = new Button();
            CurrentTaskLabel = new Label();
            CurrentTaskLayout = new Panel();
            CurrentTaskContent = new Label();
            CurrentTaskName = new Label();
            CurrentTaskLayout.SuspendLayout();
            SuspendLayout();
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
            // TasksLabel
            // 
            TasksLabel.AutoSize = true;
            TasksLabel.Location = new Point(57, 7);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(66, 15);
            TasksLabel.TabIndex = 1;
            TasksLabel.Text = "Все задачи";
            // 
            // TasksLayout
            // 
            TasksLayout.BackColor = Color.Transparent;
            TasksLayout.ColumnCount = 2;
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            TasksLayout.Location = new Point(57, 24);
            TasksLayout.Margin = new Padding(3, 2, 3, 2);
            TasksLayout.Name = "TasksLayout";
            TasksLayout.RowCount = 1;
            TasksLayout.RowStyles.Add(new RowStyle());
            TasksLayout.Size = new Size(354, 307);
            TasksLayout.TabIndex = 2;
            // 
            // NewTaskButton
            // 
            NewTaskButton.Location = new Point(444, 298);
            NewTaskButton.Margin = new Padding(3, 2, 3, 2);
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.Size = new Size(111, 32);
            NewTaskButton.TabIndex = 3;
            NewTaskButton.Text = "Новое задание";
            NewTaskButton.UseVisualStyleBackColor = true;
            NewTaskButton.Click += NewTaskButton_Click;
            // 
            // CurrentTaskLabel
            // 
            CurrentTaskLabel.AutoSize = true;
            CurrentTaskLabel.Location = new Point(416, 7);
            CurrentTaskLabel.Name = "CurrentTaskLabel";
            CurrentTaskLabel.Size = new Size(130, 15);
            CurrentTaskLabel.TabIndex = 4;
            CurrentTaskLabel.Text = "Информация о задаче";
            CurrentTaskLabel.Visible = false;
            // 
            // CurrentTaskLayout
            // 
            CurrentTaskLayout.BackColor = Color.Transparent;
            CurrentTaskLayout.Controls.Add(CurrentTaskContent);
            CurrentTaskLayout.Controls.Add(CurrentTaskName);
            CurrentTaskLayout.Location = new Point(416, 24);
            CurrentTaskLayout.Margin = new Padding(3, 2, 3, 2);
            CurrentTaskLayout.Name = "CurrentTaskLayout";
            CurrentTaskLayout.Size = new Size(170, 270);
            CurrentTaskLayout.TabIndex = 5;
            CurrentTaskLayout.Visible = false;
            // 
            // CurrentTaskContent
            // 
            CurrentTaskContent.Location = new Point(3, 87);
            CurrentTaskContent.Name = "CurrentTaskContent";
            CurrentTaskContent.Size = new Size(164, 60);
            CurrentTaskContent.TabIndex = 1;
            // 
            // CurrentTaskName
            // 
            CurrentTaskName.Location = new Point(3, 19);
            CurrentTaskName.Name = "CurrentTaskName";
            CurrentTaskName.Size = new Size(164, 60);
            CurrentTaskName.TabIndex = 0;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 346);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(CurrentTaskLayout);
            Controls.Add(CurrentTaskLabel);
            Controls.Add(NewTaskButton);
            Controls.Add(TasksLayout);
            Controls.Add(TasksLabel);
            MainMenuStrip = collapsibleSidebar1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(614, 385);
            MinimizeBox = false;
            MinimumSize = new Size(614, 385);
            Name = "TasksForm";
            Text = "TasksForm";
            CurrentTaskLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label TasksLabel;
        private TableLayoutPanel TasksLayout;
        private Button NewTaskButton;
        private Label CurrentTaskLabel;
        private Panel CurrentTaskLayout;
        private Label label1;
        private Label CurrentTaskName;
        private Label CurrentTaskContent;
    }
}