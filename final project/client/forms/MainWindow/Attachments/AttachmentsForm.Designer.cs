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
            NewDocumentButton = new Button();
            DocumentsListLabel = new Label();
            DocumentsLayout = new TableLayoutPanel();
            PhotosListLabel = new Label();
            PhotosLayout = new TableLayoutPanel();
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
            collapsibleSidebar1.Padding = new Padding(5, 2, 0, 2);
            collapsibleSidebar1.Size = new Size(54, 346);
            collapsibleSidebar1.TabIndex = 0;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // NewDocumentButton
            // 
            NewDocumentButton.Location = new Point(501, 297);
            NewDocumentButton.Margin = new Padding(3, 2, 3, 2);
            NewDocumentButton.Name = "NewDocumentButton";
            NewDocumentButton.Size = new Size(88, 38);
            NewDocumentButton.TabIndex = 13;
            NewDocumentButton.Text = "Новый документ";
            NewDocumentButton.UseVisualStyleBackColor = true;
            NewDocumentButton.Click += NewDocumentButton_Click;
            // 
            // DocumentsListLabel
            // 
            DocumentsListLabel.AutoSize = true;
            DocumentsListLabel.BackColor = Color.Transparent;
            DocumentsListLabel.Location = new Point(57, 9);
            DocumentsListLabel.Name = "DocumentsListLabel";
            DocumentsListLabel.Size = new Size(116, 15);
            DocumentsListLabel.TabIndex = 15;
            DocumentsListLabel.Text = "Список документов";
            // 
            // DocumentsLayout
            // 
            DocumentsLayout.AutoScroll = true;
            DocumentsLayout.BackColor = Color.Transparent;
            DocumentsLayout.ColumnCount = 3;
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            DocumentsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            DocumentsLayout.Location = new Point(57, 26);
            DocumentsLayout.Margin = new Padding(3, 2, 3, 2);
            DocumentsLayout.Name = "DocumentsLayout";
            DocumentsLayout.RowCount = 1;
            DocumentsLayout.RowStyles.Add(new RowStyle());
            DocumentsLayout.Size = new Size(344, 131);
            DocumentsLayout.TabIndex = 14;
            // 
            // PhotosListLabel
            // 
            PhotosListLabel.AutoSize = true;
            PhotosListLabel.BackColor = Color.Transparent;
            PhotosListLabel.Location = new Point(57, 184);
            PhotosListLabel.Name = "PhotosListLabel";
            PhotosListLabel.Size = new Size(79, 15);
            PhotosListLabel.TabIndex = 22;
            PhotosListLabel.Text = "Список фото";
            // 
            // PhotosLayout
            // 
            PhotosLayout.AutoScroll = true;
            PhotosLayout.BackColor = Color.Transparent;
            PhotosLayout.ColumnCount = 3;
            PhotosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PhotosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            PhotosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PhotosLayout.Location = new Point(57, 201);
            PhotosLayout.Margin = new Padding(3, 2, 3, 2);
            PhotosLayout.Name = "PhotosLayout";
            PhotosLayout.RowCount = 1;
            PhotosLayout.RowStyles.Add(new RowStyle());
            PhotosLayout.Size = new Size(344, 131);
            PhotosLayout.TabIndex = 23;
            // 
            // NewPhotoButton
            // 
            NewPhotoButton.Location = new Point(407, 297);
            NewPhotoButton.Margin = new Padding(3, 2, 3, 2);
            NewPhotoButton.Name = "NewPhotoButton";
            NewPhotoButton.Size = new Size(88, 38);
            NewPhotoButton.TabIndex = 24;
            NewPhotoButton.Text = "Новое фото";
            NewPhotoButton.UseVisualStyleBackColor = true;
            NewPhotoButton.Click += NewPhotoButton_Click;
            // 
            // AttachmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_30_11_56_46;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 346);
            Controls.Add(NewDocumentButton);
            Controls.Add(NewPhotoButton);
            Controls.Add(PhotosLayout);
            Controls.Add(PhotosListLabel);
            Controls.Add(DocumentsListLabel);
            Controls.Add(DocumentsLayout);
            Controls.Add(collapsibleSidebar1);
            MainMenuStrip = collapsibleSidebar1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(614, 385);
            MinimizeBox = false;
            MinimumSize = new Size(614, 385);
            Name = "AttachmentsForm";
            Text = "Управление материалами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CollapsibleSidebar collapsibleSidebar1;
        private Button NewDocumentButton;
        private Label DocumentsListLabel;
        private TableLayoutPanel DocumentsLayout;
        private Label PhotosListLabel;
        private TableLayoutPanel PhotosLayout;
        private Button NewPhotoButton;
    }
}