namespace client.forms.Modals.NewEmployee {
    partial class NewEmployeeForm {
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
            LastNameLabel = new Label();
            LastNameInput = new TextBox();
            FirstNameInput = new TextBox();
            FirstNameLabel = new Label();
            CreateLabel = new Label();
            CancelButton = new Button();
            CreateButton = new Button();
            PositionLabel = new Label();
            PositionComboBox = new ComboBox();
            RoleLabel = new Label();
            RolesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.ImeMode = ImeMode.NoControl;
            LastNameLabel.Location = new Point(12, 90);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(61, 15);
            LastNameLabel.TabIndex = 31;
            LastNameLabel.Text = "Фамилия:";
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(99, 87);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(223, 23);
            LastNameInput.TabIndex = 30;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(99, 43);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(223, 23);
            FirstNameInput.TabIndex = 29;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.ImeMode = ImeMode.NoControl;
            FirstNameLabel.Location = new Point(12, 45);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(34, 15);
            FirstNameLabel.TabIndex = 28;
            FirstNameLabel.Text = "Имя:";
            // 
            // CreateLabel
            // 
            CreateLabel.AutoSize = true;
            CreateLabel.ImeMode = ImeMode.NoControl;
            CreateLabel.Location = new Point(95, 9);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(160, 15);
            CreateLabel.TabIndex = 27;
            CreateLabel.Text = "Введите данные сотрудника";
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 238);
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
            CreateButton.Location = new Point(192, 238);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(130, 35);
            CreateButton.TabIndex = 25;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(12, 134);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(58, 15);
            PositionLabel.TabIndex = 32;
            PositionLabel.Text = "Позиция:";
            // 
            // PositionComboBox
            // 
            PositionComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.FormattingEnabled = true;
            PositionComboBox.Location = new Point(99, 131);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new Size(223, 23);
            PositionComboBox.TabIndex = 33;
            PositionComboBox.ValueMember = "id";
            PositionComboBox.KeyDown += PositionComboBox_KeyDown;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(12, 180);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(37, 15);
            RoleLabel.TabIndex = 34;
            RoleLabel.Text = "Роль:";
            // 
            // RolesComboBox
            // 
            RolesComboBox.DisplayMember = "name";
            RolesComboBox.FormattingEnabled = true;
            RolesComboBox.Location = new Point(99, 177);
            RolesComboBox.Name = "RolesComboBox";
            RolesComboBox.Size = new Size(223, 23);
            RolesComboBox.TabIndex = 35;
            RolesComboBox.ValueMember = "id";
            // 
            // NewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 285);
            Controls.Add(RolesComboBox);
            Controls.Add(RoleLabel);
            Controls.Add(PositionComboBox);
            Controls.Add(PositionLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameInput);
            Controls.Add(FirstNameInput);
            Controls.Add(FirstNameLabel);
            Controls.Add(CreateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
            Name = "NewEmployeeForm";
            Text = "Добавить сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LastNameLabel;
        private TextBox LastNameInput;
        private TextBox FirstNameInput;
        private Label FirstNameLabel;
        private Label CreateLabel;
        private Button CancelButton;
        private Button CreateButton;
        private Label PositionLabel;
        private ComboBox PositionComboBox;
        private Label RoleLabel;
        private ComboBox RolesComboBox;
    }
}