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
            SaveObjectInfoButton = new Button();
            NewTaskButton = new Button();
            NewPhotoButton = new Button();
            PhotosLayout = new TableLayoutPanel();
            PhotosLabel = new Label();
            NewDocumentButton = new Button();
            DocumentsLayout = new TableLayoutPanel();
            DocumentsLabel = new Label();
            TasksYoursCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(165, 0);
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
            ObjectsLabel.Location = new Point(57, 4);
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
            ChosenInfoLayout.Size = new Size(180, 172);
            ChosenInfoLayout.TabIndex = 8;
            ChosenInfoLayout.Visible = false;
            // 
            // TasksLabel
            // 
            TasksLabel.AutoSize = true;
            TasksLabel.BackColor = Color.Transparent;
            TasksLabel.Location = new Point(57, 228);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(46, 15);
            TasksLabel.TabIndex = 9;
            TasksLabel.Text = "Задачи";
            TasksLabel.Visible = false;
            // 
            // TasksLayout
            // 
            TasksLayout.AutoScroll = true;
            TasksLayout.BackColor = Color.Transparent;
            TasksLayout.ColumnCount = 2;
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            TasksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            TasksLayout.Location = new Point(57, 249);
            TasksLayout.Margin = new Padding(3, 2, 3, 2);
            TasksLayout.Name = "TasksLayout";
            TasksLayout.RowCount = 1;
            TasksLayout.RowStyles.Add(new RowStyle());
            TasksLayout.Size = new Size(200, 82);
            TasksLayout.TabIndex = 10;
            TasksLayout.Visible = false;
            // 
            // SaveObjectInfoButton
            // 
            SaveObjectInfoButton.Location = new Point(405, 198);
            SaveObjectInfoButton.Name = "SaveObjectInfoButton";
            SaveObjectInfoButton.Size = new Size(181, 23);
            SaveObjectInfoButton.TabIndex = 11;
            SaveObjectInfoButton.Text = "Сохранить изменения";
            SaveObjectInfoButton.UseVisualStyleBackColor = true;
            SaveObjectInfoButton.Visible = false;
            SaveObjectInfoButton.Click += SaveObjectInfoButton_Click;
            // 
            // NewTaskButton
            // 
            NewTaskButton.Location = new Point(109, 223);
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.Size = new Size(24, 24);
            NewTaskButton.TabIndex = 12;
            NewTaskButton.Text = "🔗";
            NewTaskButton.UseVisualStyleBackColor = true;
            NewTaskButton.Visible = false;
            NewTaskButton.Click += NewTaskButton_Click;
            // 
            // NewPhotoButton
            // 
            NewPhotoButton.Location = new Point(468, 223);
            NewPhotoButton.Name = "NewPhotoButton";
            NewPhotoButton.Size = new Size(24, 24);
            NewPhotoButton.TabIndex = 15;
            NewPhotoButton.Text = "🔗";
            NewPhotoButton.UseVisualStyleBackColor = true;
            NewPhotoButton.Visible = false;
            // 
            // PhotosLayout
            // 
            PhotosLayout.AutoScroll = true;
            PhotosLayout.BackColor = Color.Transparent;
            PhotosLayout.ColumnCount = 2;
            PhotosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            PhotosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            PhotosLayout.Location = new Point(427, 249);
            PhotosLayout.Margin = new Padding(3, 2, 3, 2);
            PhotosLayout.Name = "PhotosLayout";
            PhotosLayout.RowCount = 1;
            PhotosLayout.RowStyles.Add(new RowStyle());
            PhotosLayout.Size = new Size(159, 82);
            PhotosLayout.TabIndex = 14;
            PhotosLayout.Visible = false;
            // 
            // PhotosLabel
            // 
            PhotosLabel.AutoSize = true;
            PhotosLabel.BackColor = Color.Transparent;
            PhotosLabel.Location = new Point(427, 228);
            PhotosLabel.Name = "PhotosLabel";
            PhotosLabel.Size = new Size(35, 15);
            PhotosLabel.TabIndex = 13;
            PhotosLabel.Text = "Фото";
            PhotosLabel.Visible = false;
            // 
            // NewDocumentButton
            // 
            NewDocumentButton.Location = new Point(339, 223);
            NewDocumentButton.Name = "NewDocumentButton";
            NewDocumentButton.Size = new Size(24, 24);
            NewDocumentButton.TabIndex = 18;
            NewDocumentButton.Text = "🔗";
            NewDocumentButton.UseVisualStyleBackColor = true;
            NewDocumentButton.Visible = false;
            // 
            // DocumentsLayout
            // 
            DocumentsLayout.AutoScroll = true;
            DocumentsLayout.BackColor = Color.Transparent;
            DocumentsLayout.ColumnCount = 2;
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            DocumentsLayout.Location = new Point(263, 249);
            DocumentsLayout.Margin = new Padding(3, 2, 3, 2);
            DocumentsLayout.Name = "DocumentsLayout";
            DocumentsLayout.RowCount = 1;
            DocumentsLayout.RowStyles.Add(new RowStyle());
            DocumentsLayout.Size = new Size(159, 82);
            DocumentsLayout.TabIndex = 17;
            DocumentsLayout.Visible = false;
            // 
            // DocumentsLabel
            // 
            DocumentsLabel.AutoSize = true;
            DocumentsLabel.BackColor = Color.Transparent;
            DocumentsLabel.Location = new Point(263, 228);
            DocumentsLabel.Name = "DocumentsLabel";
            DocumentsLabel.Size = new Size(70, 15);
            DocumentsLabel.TabIndex = 16;
            DocumentsLabel.Text = "Документы";
            DocumentsLabel.Visible = false;
            // 
            // TasksYoursCheckBox
            // 
            TasksYoursCheckBox.AutoSize = true;
            TasksYoursCheckBox.BackColor = Color.Transparent;
            TasksYoursCheckBox.Checked = true;
            TasksYoursCheckBox.CheckState = CheckState.Checked;
            TasksYoursCheckBox.Location = new Point(139, 226);
            TasksYoursCheckBox.Name = "TasksYoursCheckBox";
            TasksYoursCheckBox.Size = new Size(99, 19);
            TasksYoursCheckBox.TabIndex = 19;
            TasksYoursCheckBox.Text = "Только ваши";
            TasksYoursCheckBox.UseVisualStyleBackColor = false;
            TasksYoursCheckBox.Visible = false;
            // 
            // ObjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 346);
            Controls.Add(TasksYoursCheckBox);
            Controls.Add(NewDocumentButton);
            Controls.Add(DocumentsLayout);
            Controls.Add(DocumentsLabel);
            Controls.Add(NewPhotoButton);
            Controls.Add(PhotosLayout);
            Controls.Add(PhotosLabel);
            Controls.Add(NewTaskButton);
            Controls.Add(SaveObjectInfoButton);
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
            Text = "Управление объектами";
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
        private Button SaveObjectInfoButton;
        private Button NewTaskButton;
        private Button NewPhotoButton;
        private TableLayoutPanel PhotosLayout;
        private Label PhotosLabel;
        private Button NewDocumentButton;
        private TableLayoutPanel DocumentsLayout;
        private Label DocumentsLabel;
        private CheckBox TasksYoursCheckBox;
    }
}