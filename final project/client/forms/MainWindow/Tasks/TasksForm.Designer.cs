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
            tableLayoutPanel1 = new TableLayoutPanel();
            NewTaskButton = new Button();
            CurrentTaskLabel = new Label();
            panel1 = new Panel();
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
            collapsibleSidebar1.Size = new Size(62, 453);
            collapsibleSidebar1.TabIndex = 0;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // TasksLabel
            // 
            TasksLabel.AutoSize = true;
            TasksLabel.Location = new Point(65, 9);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(85, 20);
            TasksLabel.TabIndex = 1;
            TasksLabel.Text = "Все задачи";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Location = new Point(65, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(405, 409);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // NewTaskButton
            // 
            NewTaskButton.Location = new Point(507, 398);
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.Size = new Size(127, 43);
            NewTaskButton.TabIndex = 3;
            NewTaskButton.Text = "Новое задание";
            NewTaskButton.UseVisualStyleBackColor = true;
            // 
            // CurrentTaskLabel
            // 
            CurrentTaskLabel.AutoSize = true;
            CurrentTaskLabel.Location = new Point(476, 9);
            CurrentTaskLabel.Name = "CurrentTaskLabel";
            CurrentTaskLabel.Size = new Size(166, 20);
            CurrentTaskLabel.TabIndex = 4;
            CurrentTaskLabel.Text = "Информация о задаче";
            CurrentTaskLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(476, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 360);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            Controls.Add(CurrentTaskLabel);
            Controls.Add(NewTaskButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TasksLabel);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "TasksForm";
            Text = "TasksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Label TasksLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button NewTaskButton;
        private Label CurrentTaskLabel;
        private Panel panel1;
    }
}