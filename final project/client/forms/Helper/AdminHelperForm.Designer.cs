namespace client.forms.Helper {
    partial class AdminHelperForm {
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
            WelcomeLabel = new Label();
            InitializeLabel = new Label();
            RepeatPasswordInput = new TextBox();
            RepeatPasswordLabel = new Label();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            UsernameInput = new TextBox();
            UsernameLabel = new Label();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.Font = new Font("Segoe UI", 15F);
            ContinueButton.Location = new Point(12, 340);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(280, 50);
            ContinueButton.TabIndex = 7;
            ContinueButton.Text = "Продолжить";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += this.StartButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("Segoe UI", 15F);
            WelcomeLabel.Location = new Point(12, 60);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(280, 56);
            WelcomeLabel.TabIndex = 5;
            WelcomeLabel.Text = "Настройка профиля Администратора";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            WelcomeLabel.Click += this.WelcomeLabel_Click;
            // 
            // InitializeLabel
            // 
            InitializeLabel.Font = new Font("Segoe UI", 15F);
            InitializeLabel.Location = new Point(12, 10);
            InitializeLabel.Name = "InitializeLabel";
            InitializeLabel.Size = new Size(280, 30);
            InitializeLabel.TabIndex = 4;
            InitializeLabel.Text = "Cherry: Инициализация";
            InitializeLabel.TextAlign = ContentAlignment.MiddleLeft;
            InitializeLabel.Click += InitializeLabel_Click;
            // 
            // RepeatPasswordInput
            // 
            RepeatPasswordInput.Location = new Point(12, 275);
            RepeatPasswordInput.Name = "RepeatPasswordInput";
            RepeatPasswordInput.PasswordChar = '*';
            RepeatPasswordInput.Size = new Size(280, 23);
            RepeatPasswordInput.TabIndex = 39;
            RepeatPasswordInput.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.Font = new Font("Segoe UI", 10F);
            RepeatPasswordLabel.Location = new Point(12, 245);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(280, 30);
            RepeatPasswordLabel.TabIndex = 38;
            RepeatPasswordLabel.Text = "Повторите пароль:";
            RepeatPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 219);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(280, 23);
            PasswordInput.TabIndex = 37;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(12, 189);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(280, 30);
            PasswordLabel.TabIndex = 36;
            PasswordLabel.Text = "Пароль:";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(12, 163);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(280, 23);
            UsernameInput.TabIndex = 33;
            UsernameInput.Text = "admin";
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(12, 130);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(280, 30);
            UsernameLabel.TabIndex = 32;
            UsernameLabel.Text = "Имя пользователя:";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminHelperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(RepeatPasswordInput);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Controls.Add(ContinueButton);
            Controls.Add(WelcomeLabel);
            Controls.Add(InitializeLabel);
            Name = "AdminHelperForm";
            Text = "AdminHelperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ContinueButton;
        private Label WelcomeLabel;
        private Label InitializeLabel;
        private TextBox RepeatPasswordInput;
        private Label RepeatPasswordLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private TextBox UsernameInput;
        private Label UsernameLabel;
    }
}