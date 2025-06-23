namespace client.forms.Modals.LinkPhoto {
    partial class LinkPhotoForm {
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
            DescriptionLabel = new Label();
            CancelButton = new Button();
            LinkButton = new Button();
            SearchInput = new TextBox();
            SearchLabel = new Label();
            ChooseLabel = new Label();
            PhotoList = new ComboBox();
            SuspendLayout();
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Location = new Point(12, 54);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(310, 29);
            DescriptionLabel.TabIndex = 24;
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 119);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 35);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // LinkButton
            // 
            LinkButton.BackColor = Color.FromArgb(192, 255, 192);
            LinkButton.ImeMode = ImeMode.NoControl;
            LinkButton.Location = new Point(192, 119);
            LinkButton.Name = "LinkButton";
            LinkButton.Size = new Size(130, 35);
            LinkButton.TabIndex = 22;
            LinkButton.Text = "Привязать";
            LinkButton.UseVisualStyleBackColor = false;
            LinkButton.Click += LinkButton_Click;
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(111, 90);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(211, 23);
            SearchInput.TabIndex = 21;
            SearchInput.KeyDown += SearchInput_KeyDown;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(51, 93);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(54, 15);
            SearchLabel.TabIndex = 20;
            SearchLabel.Text = "Поиск🔎";
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(12, 10);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(148, 15);
            ChooseLabel.TabIndex = 19;
            ChooseLabel.Text = "Выберите фото из списка";
            // 
            // PhotoList
            // 
            PhotoList.DropDownStyle = ComboBoxStyle.DropDownList;
            PhotoList.FormattingEnabled = true;
            PhotoList.Location = new Point(12, 28);
            PhotoList.Name = "PhotoList";
            PhotoList.Size = new Size(310, 23);
            PhotoList.TabIndex = 18;
            PhotoList.SelectedIndexChanged += PhotoList_Update;
            // 
            // LinkPhotoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 165);
            Controls.Add(DescriptionLabel);
            Controls.Add(CancelButton);
            Controls.Add(LinkButton);
            Controls.Add(SearchInput);
            Controls.Add(SearchLabel);
            Controls.Add(ChooseLabel);
            Controls.Add(PhotoList);
            Name = "LinkPhotoForm";
            Text = "Призявать фото";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DescriptionLabel;
        private Button CancelButton;
        private Button LinkButton;
        private TextBox SearchInput;
        private Label SearchLabel;
        private Label ChooseLabel;
        private ComboBox PhotoList;
    }
}