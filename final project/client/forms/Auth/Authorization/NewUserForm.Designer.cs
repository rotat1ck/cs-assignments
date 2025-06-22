namespace client.forms.Auth.Authorization {
    partial class NewUserForm {
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
            RepeatPasswordInput = new TextBox();
            RepeatPasswordLabel = new Label();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            RegisterButton = new Button();
            EmailInput = new TextBox();
            EmailLabel = new Label();
            UsernameInput = new TextBox();
            UsernameLabel = new Label();
            RegisterLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // RepeatPasswordInput
            // 
            RepeatPasswordInput.Location = new Point(12, 287);
            RepeatPasswordInput.Name = "RepeatPasswordInput";
            RepeatPasswordInput.PasswordChar = '*';
            RepeatPasswordInput.Size = new Size(280, 23);
            RepeatPasswordInput.TabIndex = 31;
            RepeatPasswordInput.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.Font = new Font("Segoe UI", 10F);
            RepeatPasswordLabel.Location = new Point(12, 257);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(280, 30);
            RepeatPasswordLabel.TabIndex = 30;
            RepeatPasswordLabel.Text = "Повторите пароль:";
            RepeatPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 231);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(280, 23);
            PasswordInput.TabIndex = 29;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(12, 201);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(280, 30);
            PasswordLabel.TabIndex = 28;
            PasswordLabel.Text = "Пароль:";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 20F);
            RegisterButton.Location = new Point(12, 340);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(280, 50);
            RegisterButton.TabIndex = 27;
            RegisterButton.Text = "Создать и войти";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(12, 175);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(280, 23);
            EmailInput.TabIndex = 24;
            // 
            // EmailLabel
            // 
            EmailLabel.Font = new Font("Segoe UI", 10F);
            EmailLabel.Location = new Point(12, 145);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(280, 30);
            EmailLabel.TabIndex = 23;
            EmailLabel.Text = "Адрес почты:";
            EmailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(12, 119);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(280, 23);
            UsernameInput.TabIndex = 22;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(12, 89);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(280, 30);
            UsernameLabel.TabIndex = 21;
            UsernameLabel.Text = "Имя пользователя:";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterLabel
            // 
            RegisterLabel.Font = new Font("Segoe UI", 16F);
            RegisterLabel.Location = new Point(12, 10);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(280, 30);
            RegisterLabel.TabIndex = 20;
            RegisterLabel.Text = "Cherry: Авторизация";
            RegisterLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(207, 49);
            label1.TabIndex = 32;
            label1.Text = "Введите данные для вашей учетной записи";
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(label1);
            Controls.Add(RepeatPasswordInput);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(RegisterButton);
            Controls.Add(EmailInput);
            Controls.Add(EmailLabel);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Controls.Add(RegisterLabel);
            Name = "NewUserForm";
            Text = "Создание учетной записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RepeatPasswordInput;
        private Label RepeatPasswordLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private Button RegisterButton;
        private TextBox EmailInput;
        private Label EmailLabel;
        private TextBox UsernameInput;
        private Label UsernameLabel;
        private Label RegisterLabel;
        private Label label1;
    }
}