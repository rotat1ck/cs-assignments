namespace client {
    partial class ObjectsManagementForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            NewObjectButton = new Button();
            collapsibleSidebar1 = new forms.MainWindow.CollapsibleSidebar();
            ObjectsLayout = new TableLayoutPanel();
            ObjectsLabel = new Label();
            ObjectInfoLabel = new Label();
            ObjectInfoLayout = new Panel();
            TasksLabel = new Label();
            TasksLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(551, 412);
            NewObjectButton.Name = "NewObjectButton";
            NewObjectButton.Size = new Size(119, 29);
            NewObjectButton.TabIndex = 3;
            NewObjectButton.Text = "Новый объект";
            NewObjectButton.UseVisualStyleBackColor = true;
            NewObjectButton.Click += NewObjectButton_Click;
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
            collapsibleSidebar1.TabIndex = 4;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // ObjectsLayout
            // 
            ObjectsLayout.AutoScroll = true;
            ObjectsLayout.BackColor = Color.Transparent;
            ObjectsLayout.ColumnCount = 2;
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ObjectsLayout.Location = new Point(65, 32);
            ObjectsLayout.Name = "ObjectsLayout";
            ObjectsLayout.RowCount = 1;
            ObjectsLayout.RowStyles.Add(new RowStyle());
            ObjectsLayout.Size = new Size(393, 263);
            ObjectsLayout.TabIndex = 5;
            // 
            // ObjectsLabel
            // 
            ObjectsLabel.AutoSize = true;
            ObjectsLabel.BackColor = Color.Transparent;
            ObjectsLabel.Location = new Point(65, 9);
            ObjectsLabel.Name = "ObjectsLabel";
            ObjectsLabel.Size = new Size(128, 20);
            ObjectsLabel.TabIndex = 6;
            ObjectsLabel.Text = "Список объектов";
            // 
            // ObjectInfoLabel
            // 
            ObjectInfoLabel.AutoSize = true;
            ObjectInfoLabel.BackColor = Color.Transparent;
            ObjectInfoLabel.Location = new Point(463, 9);
            ObjectInfoLabel.Name = "ObjectInfoLabel";
            ObjectInfoLabel.Size = new Size(175, 20);
            ObjectInfoLabel.TabIndex = 7;
            ObjectInfoLabel.Text = "Информация о объекте";
            ObjectInfoLabel.Visible = false;
            // 
            // ObjectInfoLayout
            // 
            ObjectInfoLayout.BackColor = Color.Transparent;
            ObjectInfoLayout.Location = new Point(464, 32);
            ObjectInfoLayout.Name = "ObjectInfoLayout";
            ObjectInfoLayout.Size = new Size(206, 263);
            ObjectInfoLayout.TabIndex = 8;
            ObjectInfoLayout.Visible = false;
            // 
            // TasksLabel
            // 
            TasksLabel.AutoSize = true;
            TasksLabel.BackColor = Color.Transparent;
            TasksLabel.Location = new Point(65, 309);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(176, 20);
            TasksLabel.TabIndex = 9;
            TasksLabel.Text = "Прикрепленные задачи";
            TasksLabel.Visible = false;
            // 
            // TasksLayout
            // 
            TasksLayout.AutoScroll = true;
            TasksLayout.BackColor = Color.Transparent;
            TasksLayout.ColumnCount = 2;
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TasksLayout.Location = new Point(65, 332);
            TasksLayout.Name = "TasksLayout";
            TasksLayout.RowCount = 1;
            TasksLayout.RowStyles.Add(new RowStyle());
            TasksLayout.Size = new Size(393, 109);
            TasksLayout.TabIndex = 10;
            TasksLayout.Visible = false;
            // 
            // ObjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 453);
            Controls.Add(TasksLayout);
            Controls.Add(NewObjectButton);
            Controls.Add(TasksLabel);
            Controls.Add(ObjectInfoLayout);
            Controls.Add(ObjectInfoLabel);
            Controls.Add(ObjectsLabel);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(ObjectsLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "ObjectsManagementForm";
            Text = "Object Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TestLabel;
        private Button NewObjectButton;
        private forms.MainWindow.CollapsibleSidebar collapsibleSidebar1;
        private TableLayoutPanel ObjectsLayout;
        private Label ObjectsLabel;
        private Label ObjectInfoLabel;
        private Panel ObjectInfoLayout;
        private Label TasksLabel;
        private TableLayoutPanel TasksLayout;
    }
}