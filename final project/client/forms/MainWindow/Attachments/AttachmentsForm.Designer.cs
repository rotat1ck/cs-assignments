namespace client.forms.MainWindow
{
    partial class AttachmentsForm
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
            NewTaskButton = new Button();
            SaveObjectInfoButton = new Button();
            NewDocumentButton = new Button();
            ChosenInfoLayout = new Panel();
            ChosenInfoLabel = new Label();
            DocumentsListLabel = new Label();
            DocumentsLayout = new TableLayoutPanel();
            PhotosListLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            NewPhotoButton = new Button();
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
            // NewTaskButton
            // 
            NewTaskButton.Location = new Point(550, 303);
            NewTaskButton.Margin = new Padding(3, 4, 3, 4);
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.Size = new Size(120, 53);
            NewTaskButton.TabIndex = 21;
            NewTaskButton.Text = "Привязать задачу";
            NewTaskButton.UseVisualStyleBackColor = true;
            NewTaskButton.Visible = false;
            // 
            // SaveObjectInfoButton
            // 
            SaveObjectInfoButton.Location = new Point(463, 264);
            SaveObjectInfoButton.Margin = new Padding(3, 4, 3, 4);
            SaveObjectInfoButton.Name = "SaveObjectInfoButton";
            SaveObjectInfoButton.Size = new Size(207, 31);
            SaveObjectInfoButton.TabIndex = 20;
            SaveObjectInfoButton.Text = "Сохранить изменения";
            SaveObjectInfoButton.UseVisualStyleBackColor = true;
            SaveObjectInfoButton.Visible = false;
            // 
            // NewDocumentButton
            // 
            NewDocumentButton.Location = new Point(464, 393);
            NewDocumentButton.Name = "NewDocumentButton";
            NewDocumentButton.Size = new Size(100, 50);
            NewDocumentButton.TabIndex = 13;
            NewDocumentButton.Text = "Новый документ";
            NewDocumentButton.UseVisualStyleBackColor = true;
            // 
            // ChosenInfoLayout
            // 
            ChosenInfoLayout.BackColor = Color.Transparent;
            ChosenInfoLayout.Location = new Point(464, 32);
            ChosenInfoLayout.Margin = new Padding(3, 3, 3, 20);
            ChosenInfoLayout.Name = "ChosenInfoLayout";
            ChosenInfoLayout.Size = new Size(206, 229);
            ChosenInfoLayout.TabIndex = 17;
            ChosenInfoLayout.Visible = false;
            // 
            // ChosenInfoLabel
            // 
            ChosenInfoLabel.AutoSize = true;
            ChosenInfoLabel.BackColor = Color.Transparent;
            ChosenInfoLabel.Location = new Point(463, 9);
            ChosenInfoLabel.Name = "ChosenInfoLabel";
            ChosenInfoLabel.Size = new Size(184, 20);
            ChosenInfoLabel.TabIndex = 16;
            ChosenInfoLabel.Text = "Информация об объекте";
            ChosenInfoLabel.Visible = false;
            // 
            // DocumentsListLabel
            // 
            DocumentsListLabel.AutoSize = true;
            DocumentsListLabel.BackColor = Color.Transparent;
            DocumentsListLabel.Location = new Point(65, 9);
            DocumentsListLabel.Name = "DocumentsListLabel";
            DocumentsListLabel.Size = new Size(145, 20);
            DocumentsListLabel.TabIndex = 15;
            DocumentsListLabel.Text = "Список документов";
            // 
            // DocumentsLayout
            // 
            DocumentsLayout.AutoScroll = true;
            DocumentsLayout.BackColor = Color.Transparent;
            DocumentsLayout.ColumnCount = 3;
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            DocumentsLayout.Location = new Point(65, 32);
            DocumentsLayout.Name = "DocumentsLayout";
            DocumentsLayout.RowCount = 1;
            DocumentsLayout.RowStyles.Add(new RowStyle());
            DocumentsLayout.Size = new Size(393, 175);
            DocumentsLayout.TabIndex = 14;
            // 
            // PhotosListLabel
            // 
            PhotosListLabel.AutoSize = true;
            PhotosListLabel.BackColor = Color.Transparent;
            PhotosListLabel.Location = new Point(65, 241);
            PhotosListLabel.Name = "PhotosListLabel";
            PhotosListLabel.Size = new Size(97, 20);
            PhotosListLabel.TabIndex = 22;
            PhotosListLabel.Text = "Список фото";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Location = new Point(65, 264);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(393, 175);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // NewPhotoButton
            // 
            NewPhotoButton.Location = new Point(570, 393);
            NewPhotoButton.Name = "NewPhotoButton";
            NewPhotoButton.Size = new Size(100, 50);
            NewPhotoButton.TabIndex = 24;
            NewPhotoButton.Text = "Новый объект";
            NewPhotoButton.UseVisualStyleBackColor = true;
            // 
            // AttachmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 453);
            Controls.Add(NewPhotoButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PhotosListLabel);
            Controls.Add(NewTaskButton);
            Controls.Add(SaveObjectInfoButton);
            Controls.Add(NewDocumentButton);
            Controls.Add(ChosenInfoLayout);
            Controls.Add(ChosenInfoLabel);
            Controls.Add(DocumentsListLabel);
            Controls.Add(DocumentsLayout);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "AttachmentsForm";
            Text = "Управление материалами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Button NewTaskButton;
        private Button SaveObjectInfoButton;
        private Button NewDocumentButton;
        private Panel ChosenInfoLayout;
        private Label ChosenInfoLabel;
        private Label DocumentsListLabel;
        private TableLayoutPanel DocumentsLayout;
        private Label PhotosListLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button NewPhotoButton;
    }
}