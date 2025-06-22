namespace client.forms.Modals.NewTask {
    partial class NewTaskForm {
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
            ContentLabel = new Label();
            ContentInput = new TextBox();
            NameInput = new TextBox();
            NameLabel = new Label();
            CreateLabel = new Label();
            CancelButton = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.ImeMode = ImeMode.NoControl;
            ContentLabel.Location = new Point(12, 90);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(65, 15);
            ContentLabel.TabIndex = 24;
            ContentLabel.Text = "Описание:";
            // 
            // ContentInput
            // 
            ContentInput.Location = new Point(99, 88);
            ContentInput.Name = "ContentInput";
            ContentInput.Size = new Size(223, 23);
            ContentInput.TabIndex = 19;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(99, 43);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(223, 23);
            NameInput.TabIndex = 17;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ImeMode = ImeMode.NoControl;
            NameLabel.Location = new Point(12, 45);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(34, 15);
            NameLabel.TabIndex = 16;
            NameLabel.Text = "Имя:";
            // 
            // CreateLabel
            // 
            CreateLabel.AutoSize = true;
            CreateLabel.ImeMode = ImeMode.NoControl;
            CreateLabel.Location = new Point(95, 9);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(134, 15);
            CreateLabel.TabIndex = 15;
            CreateLabel.Text = "Введите данные задачи";
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 144);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 35);
            CancelButton.TabIndex = 14;
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
            CreateButton.TabIndex = 13;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // NewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 191);
            Controls.Add(ContentLabel);
            Controls.Add(ContentInput);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(CreateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
            MaximizeBox = false;
            MaximumSize = new Size(350, 230);
            MinimizeBox = false;
            MinimumSize = new Size(350, 230);
            Name = "NewTaskForm";
            Text = "Новая задача";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberInput;
        private Label ContentLabel;
        private TextBox LocationInput;
        private Label NumberLabel;
        private TextBox DescriptionInput;
        private Label LocationLabel;
        private TextBox ContentInput;
        private Label DescriptionLabel;
        private TextBox NameInput;
        private Label NameLabel;
        private Label CreateLabel;
        private Button CancelButton;
        private Button CreateButton;
    }
}