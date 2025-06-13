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
            collapsibleSidebar1 = new client.forms.MainWindow.CollapsibleSidebar();
            ObjectsLayout = new TableLayoutPanel();
            ObjectsLabel = new Label();
            ChosenInfoLabel = new Label();
            ChosenInfoLayout = new Panel();
            TasksLabel = new Label();
            TasksLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(482, 309);
            NewObjectButton.Margin = new Padding(3, 2, 3, 2);
            NewObjectButton.Name = "NewObjectButton";
            NewObjectButton.Size = new Size(104, 22);
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
            collapsibleSidebar1.Padding = new Padding(5, 2, 0, 2);
            collapsibleSidebar1.Size = new Size(54, 346);
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
            ObjectsLayout.Location = new Point(57, 24);
            ObjectsLayout.Margin = new Padding(3, 2, 3, 2);
            ObjectsLayout.Name = "ObjectsLayout";
            ObjectsLayout.RowCount = 1;
            ObjectsLayout.RowStyles.Add(new RowStyle());
            ObjectsLayout.Size = new Size(344, 197);
            ObjectsLayout.TabIndex = 5;
            // 
            // ObjectsLabel
            // 
            ObjectsLabel.AutoSize = true;
            ObjectsLabel.BackColor = Color.Transparent;
            ObjectsLabel.Location = new Point(57, 7);
            ObjectsLabel.Name = "ObjectsLabel";
            ObjectsLabel.Size = new Size(102, 15);
            ObjectsLabel.TabIndex = 6;
            ObjectsLabel.Text = "Список объектов";
            // 
            // ChosenInfoLabel
            // 
            ChosenInfoLabel.AutoSize = true;
            ChosenInfoLabel.BackColor = Color.Transparent;
            ChosenInfoLabel.Location = new Point(405, 7);
            ChosenInfoLabel.Name = "ChosenInfoLabel";
            ChosenInfoLabel.Size = new Size(145, 15);
            ChosenInfoLabel.TabIndex = 7;
            ChosenInfoLabel.Text = "Информация об объекте";
            ChosenInfoLabel.Visible = false;
            // 
            // ChosenInfoLayout
            // 
            ChosenInfoLayout.BackColor = Color.Transparent;
            ChosenInfoLayout.Location = new Point(406, 24);
            ChosenInfoLayout.Margin = new Padding(3, 2, 3, 15);
            ChosenInfoLayout.Name = "ChosenInfoLayout";
            ChosenInfoLayout.Size = new Size(180, 197);
            ChosenInfoLayout.TabIndex = 8;
            ChosenInfoLayout.Visible = false;
            // 
            // TasksLabel
            // 
            TasksLabel.AutoSize = true;
            TasksLabel.BackColor = Color.Transparent;
            TasksLabel.Location = new Point(57, 232);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(138, 15);
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
            TasksLayout.Location = new Point(57, 249);
            TasksLayout.Margin = new Padding(3, 2, 3, 2);
            TasksLayout.Name = "TasksLayout";
            TasksLayout.RowCount = 1;
            TasksLayout.RowStyles.Add(new RowStyle());
            TasksLayout.Size = new Size(239, 82);
            TasksLayout.TabIndex = 10;
            TasksLayout.Visible = false;
            // 
            // ObjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 346);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(TasksLayout);
            Controls.Add(NewObjectButton);
            Controls.Add(TasksLabel);
            Controls.Add(ChosenInfoLayout);
            Controls.Add(ChosenInfoLabel);
            Controls.Add(ObjectsLabel);
            Controls.Add(ObjectsLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = collapsibleSidebar1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(614, 385);
            MinimizeBox = false;
            MinimumSize = new Size(614, 385);
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
        private Label ChosenInfoLabel;
        private Panel ChosenInfoLayout;
        private Label TasksLabel;
        private TableLayoutPanel TasksLayout;
    }
}