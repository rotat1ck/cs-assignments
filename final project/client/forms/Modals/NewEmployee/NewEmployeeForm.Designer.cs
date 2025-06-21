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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 32;
            label1.Text = "Позиция:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 34;
            label2.Text = "label2";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(99, 177);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 23);
            comboBox2.TabIndex = 35;
            // 
            // NewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 285);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
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
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
    }
}