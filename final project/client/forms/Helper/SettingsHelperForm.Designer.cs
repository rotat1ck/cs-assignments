namespace client.forms.Helper {
    partial class SettingsHelperForm {
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
            ContinueButton = new Button();
            InitializeLabel = new Label();
            PasswordHashingCheckBox = new CheckBox();
            SafeRegisterCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            WelcomeLabel = new Label();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.Font = new Font("Segoe UI", 15F);
            ContinueButton.Location = new Point(12, 340);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(280, 50);
            ContinueButton.TabIndex = 42;
            ContinueButton.Text = "Завершить";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // InitializeLabel
            // 
            InitializeLabel.Font = new Font("Segoe UI", 15F);
            InitializeLabel.Location = new Point(12, 10);
            InitializeLabel.Name = "InitializeLabel";
            InitializeLabel.Size = new Size(280, 30);
            InitializeLabel.TabIndex = 40;
            InitializeLabel.Text = "Cherry: Инициализация";
            InitializeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordHashingCheckBox
            // 
            PasswordHashingCheckBox.AutoSize = true;
            PasswordHashingCheckBox.Checked = true;
            PasswordHashingCheckBox.CheckState = CheckState.Checked;
            PasswordHashingCheckBox.Font = new Font("Segoe UI", 12F);
            PasswordHashingCheckBox.Location = new Point(12, 105);
            PasswordHashingCheckBox.Name = "PasswordHashingCheckBox";
            PasswordHashingCheckBox.Size = new Size(172, 25);
            PasswordHashingCheckBox.TabIndex = 43;
            PasswordHashingCheckBox.Text = "Хэшировать пароли";
            PasswordHashingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SafeRegisterCheckBox
            // 
            SafeRegisterCheckBox.AutoSize = true;
            SafeRegisterCheckBox.Font = new Font("Segoe UI", 12F);
            SafeRegisterCheckBox.Location = new Point(12, 231);
            SafeRegisterCheckBox.Name = "SafeRegisterCheckBox";
            SafeRegisterCheckBox.Size = new Size(182, 25);
            SafeRegisterCheckBox.TabIndex = 44;
            SafeRegisterCheckBox.Text = "Простая регистрация";
            SafeRegisterCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(280, 81);
            label1.TabIndex = 45;
            label1.Text = "При хэшировании паролей администратор не сможет видеть пароли пользователей, хранение паролей становиться безопасней";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 259);
            label2.Name = "label2";
            label2.Size = new Size(280, 60);
            label2.TabIndex = 46;
            label2.Text = "Добавляет подсказки на конкретные проблемы в процессе регистрации аккаунта, небезопасная функция";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("Segoe UI", 15F);
            WelcomeLabel.Location = new Point(12, 46);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(280, 56);
            WelcomeLabel.TabIndex = 47;
            WelcomeLabel.Text = "Настройка приложения";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SettingsHelperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(WelcomeLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SafeRegisterCheckBox);
            Controls.Add(PasswordHashingCheckBox);
            Controls.Add(ContinueButton);
            Controls.Add(InitializeLabel);
            Name = "SettingsHelperForm";
            Text = "SettingsHelperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ContinueButton;
        private Label InitializeLabel;
        private CheckBox PasswordHashingCheckBox;
        private CheckBox SafeRegisterCheckBox;
        private Label label1;
        private Label label2;
        private Label WelcomeLabel;
    }
}