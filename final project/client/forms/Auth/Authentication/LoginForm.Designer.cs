namespace client.forms.Auth.Authentication {
    partial class LoginForm {
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
            SignInLabel = new Label();
            UsernameLabel = new Label();
            UsernameInput = new TextBox();
            label1 = new Label();
            PasswordInput = new TextBox();
            label2 = new Label();
            RegisterButton = new Button();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // SignInLabel
            // 
            SignInLabel.Font = new Font("Segoe UI", 16F);
            SignInLabel.Location = new Point(10, 10);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(210, 30);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Cherry: Sign In";
            SignInLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(10, 80);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(280, 30);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username or email:";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(10, 110);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(280, 23);
            UsernameInput.TabIndex = 2;
            UsernameInput.KeyDown += UsernameInput_KeyDown;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(10, 160);
            label1.Name = "label1";
            label1.Size = new Size(280, 30);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(10, 190);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(280, 23);
            PasswordInput.TabIndex = 4;
            PasswordInput.UseSystemPasswordChar = true;
            PasswordInput.KeyDown += PasswordInput_KeyDown;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(10, 300);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 5;
            label2.Text = "Don't have an account?";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 10F);
            RegisterButton.Location = new Point(180, 300);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(110, 30);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            SignInButton.Font = new Font("Segoe UI", 20F);
            SignInButton.Location = new Point(10, 340);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(280, 50);
            SignInButton.TabIndex = 7;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(SignInButton);
            Controls.Add(RegisterButton);
            Controls.Add(label2);
            Controls.Add(PasswordInput);
            Controls.Add(label1);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Controls.Add(SignInLabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignInLabel;
        private Label UsernameLabel;
        private TextBox UsernameInput;
        private Label label1;
        private TextBox PasswordInput;
        private Label label2;
        private Button RegisterButton;
        private Button SignInButton;
    }
}