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
            SignInLabel.Location = new Point(11, 13);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(240, 40);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Cherry: Sign In";
            SignInLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(11, 107);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(320, 40);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username or email:";
            UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(11, 147);
            UsernameInput.Margin = new Padding(3, 4, 3, 4);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(319, 27);
            UsernameInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 213);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(11, 253);
            PasswordInput.Margin = new Padding(3, 4, 3, 4);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(319, 27);
            PasswordInput.TabIndex = 4;
            PasswordInput.UseSystemPasswordChar = true;
            PasswordInput.KeyDown += PasswordInput_KeyDown;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 400);
            label2.Name = "label2";
            label2.Size = new Size(196, 40);
            label2.TabIndex = 5;
            label2.Text = "Don't have an account?";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 10F);
            RegisterButton.Location = new Point(206, 400);
            RegisterButton.Margin = new Padding(3, 4, 3, 4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(126, 40);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            SignInButton.Font = new Font("Segoe UI", 20F);
            SignInButton.Location = new Point(11, 453);
            SignInButton.Margin = new Padding(3, 4, 3, 4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(320, 67);
            SignInButton.TabIndex = 7;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 535);
            Controls.Add(SignInButton);
            Controls.Add(RegisterButton);
            Controls.Add(label2);
            Controls.Add(PasswordInput);
            Controls.Add(label1);
            Controls.Add(UsernameInput);
            Controls.Add(UsernameLabel);
            Controls.Add(SignInLabel);
            Margin = new Padding(3, 4, 3, 4);
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