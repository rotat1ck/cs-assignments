namespace client.forms.Modals.ResetPassword {
    partial class ResetPasswordForm {
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
            label1 = new Label();
            RepeatPasswordInput = new TextBox();
            RepeatPasswordLabel = new Label();
            PasswordInput = new TextBox();
            PasswordLabel = new Label();
            CancelButton = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите новый пароль";
            // 
            // RepeatPasswordInput
            // 
            RepeatPasswordInput.Location = new Point(12, 143);
            RepeatPasswordInput.Name = "RepeatPasswordInput";
            RepeatPasswordInput.PasswordChar = '*';
            RepeatPasswordInput.Size = new Size(210, 23);
            RepeatPasswordInput.TabIndex = 35;
            RepeatPasswordInput.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.Font = new Font("Segoe UI", 10F);
            RepeatPasswordLabel.Location = new Point(12, 113);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(210, 30);
            RepeatPasswordLabel.TabIndex = 34;
            RepeatPasswordLabel.Text = "Повторите пароль:";
            RepeatPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(12, 87);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(210, 23);
            PasswordInput.TabIndex = 33;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(12, 57);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(210, 30);
            PasswordLabel.TabIndex = 32;
            PasswordLabel.Text = "Пароль:";
            PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 195);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(100, 35);
            CancelButton.TabIndex = 37;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.ImeMode = ImeMode.NoControl;
            CreateButton.Location = new Point(122, 195);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(100, 35);
            CreateButton.TabIndex = 36;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 242);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
            Controls.Add(RepeatPasswordInput);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(PasswordInput);
            Controls.Add(PasswordLabel);
            Controls.Add(label1);
            Name = "ResetPasswordForm";
            Text = "Сброс пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RepeatPasswordInput;
        private Label RepeatPasswordLabel;
        private TextBox PasswordInput;
        private Label PasswordLabel;
        private Button CancelButton;
        private Button CreateButton;
    }
}