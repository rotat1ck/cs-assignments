namespace client.forms.Modals.NewDocument {
    partial class NewDocumentForm {
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
            LinkLabel = new Label();
            LinkInput = new TextBox();
            NameInput = new TextBox();
            NameLabel = new Label();
            CreateLabel = new Label();
            CancelButton = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // LinkLabel
            // 
            LinkLabel.AutoSize = true;
            LinkLabel.ImeMode = ImeMode.NoControl;
            LinkLabel.Location = new Point(12, 91);
            LinkLabel.Name = "LinkLabel";
            LinkLabel.Size = new Size(52, 15);
            LinkLabel.TabIndex = 31;
            LinkLabel.Text = "Ссылка:";
            // 
            // LinkInput
            // 
            LinkInput.Location = new Point(99, 89);
            LinkInput.Name = "LinkInput";
            LinkInput.Size = new Size(223, 23);
            LinkInput.TabIndex = 30;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(99, 44);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(223, 23);
            NameInput.TabIndex = 29;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(12, 46);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(34, 15);
            NameLabel.TabIndex = 28;
            NameLabel.Text = "Имя:";
            // 
            // CreateLabel
            // 
            CreateLabel.AutoSize = true;
            CreateLabel.ImeMode = ImeMode.NoControl;
            CreateLabel.Location = new Point(95, 10);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(155, 15);
            CreateLabel.TabIndex = 27;
            CreateLabel.Text = "Введите данные документа";
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 144);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 35);
            CancelButton.TabIndex = 26;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.ImeMode = ImeMode.NoControl;
            CreateButton.Location = new Point(192, 144);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(130, 35);
            CreateButton.TabIndex = 25;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // NewDocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 191);
            Controls.Add(LinkLabel);
            Controls.Add(LinkInput);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(CreateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
            Name = "NewDocumentForm";
            Text = "Новый документ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LinkLabel;
        private TextBox LinkInput;
        private TextBox NameInput;
        private Label NameLabel;
        private Label CreateLabel;
        private Button CancelButton;
        private Button CreateButton;
    }
}