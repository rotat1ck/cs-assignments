namespace client.forms.Auth.Authorization {
    partial class RegistrationForm {
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
            RegisterButton = new Button();
            LoginButton = new Button();
            label2 = new Label();
            LastNameInput = new TextBox();
            LastNameLabel = new Label();
            FirstNameInput = new TextBox();
            FirstNameLabel = new Label();
            RegisterLabel = new Label();
            RoleInput = new TextBox();
            RoleLabel = new Label();
            PositionInput = new TextBox();
            PositionLabel = new Label();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 20F);
            RegisterButton.Location = new Point(12, 340);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(280, 50);
            RegisterButton.TabIndex = 15;
            RegisterButton.Text = "Продолжить";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 10F);
            LoginButton.Location = new Point(190, 300);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(102, 30);
            LoginButton.TabIndex = 14;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 13;
            label2.Text = "У вас уже есть аккаунт?";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(12, 139);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(280, 23);
            LastNameInput.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            LastNameLabel.Font = new Font("Segoe UI", 10F);
            LastNameLabel.Location = new Point(12, 106);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(280, 30);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Фамилия:";
            LastNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(12, 80);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(280, 23);
            FirstNameInput.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.Font = new Font("Segoe UI", 10F);
            FirstNameLabel.Location = new Point(12, 50);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(280, 30);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "Имя:";
            FirstNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterLabel
            // 
            RegisterLabel.Font = new Font("Segoe UI", 16F);
            RegisterLabel.Location = new Point(12, 10);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(280, 30);
            RegisterLabel.TabIndex = 8;
            RegisterLabel.Text = "Cherry: Авторизация";
            RegisterLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoleInput
            // 
            RoleInput.Location = new Point(12, 248);
            RoleInput.Name = "RoleInput";
            RoleInput.Size = new Size(280, 23);
            RoleInput.TabIndex = 19;
            // 
            // RoleLabel
            // 
            RoleLabel.Font = new Font("Segoe UI", 10F);
            RoleLabel.Location = new Point(12, 218);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(280, 30);
            RoleLabel.TabIndex = 18;
            RoleLabel.Text = "Роль:";
            RoleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PositionInput
            // 
            PositionInput.Location = new Point(12, 192);
            PositionInput.Name = "PositionInput";
            PositionInput.Size = new Size(280, 23);
            PositionInput.TabIndex = 17;
            // 
            // PositionLabel
            // 
            PositionLabel.Font = new Font("Segoe UI", 10F);
            PositionLabel.Location = new Point(12, 162);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(280, 30);
            PositionLabel.TabIndex = 16;
            PositionLabel.Text = "Позиция:";
            PositionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(RoleInput);
            Controls.Add(RoleLabel);
            Controls.Add(PositionInput);
            Controls.Add(PositionLabel);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(LastNameInput);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameInput);
            Controls.Add(FirstNameLabel);
            Controls.Add(RegisterLabel);
            Name = "RegistrationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Button LoginButton;
        private Label label2;
        private TextBox LastNameInput;
        private Label LastNameLabel;
        private TextBox FirstNameInput;
        private Label FirstNameLabel;
        private Label RegisterLabel;
        private TextBox RoleInput;
        private Label RoleLabel;
        private TextBox PositionInput;
        private Label PositionLabel;
    }
}