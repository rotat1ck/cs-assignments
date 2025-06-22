namespace client.forms.Helper {
    partial class EntryForm {
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
            InitializeLabel = new Label();
            WelcomeLabel = new Label();
            InfoLabel = new Label();
            StartButton = new Button();
            SuspendLayout();
            // 
            // InitializeLabel
            // 
            InitializeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            InitializeLabel.Location = new Point(10, 10);
            InitializeLabel.Name = "InitializeLabel";
            InitializeLabel.Size = new Size(280, 30);
            InitializeLabel.TabIndex = 0;
            InitializeLabel.Text = "Cherry: Инициализация";
            InitializeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("Segoe UI", 15F);
            WelcomeLabel.Location = new Point(10, 60);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(280, 56);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Добро Пожаловать, Администратор";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InfoLabel
            // 
            InfoLabel.Font = new Font("Segoe UI", 12F);
            InfoLabel.Location = new Point(10, 260);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(280, 80);
            InfoLabel.TabIndex = 2;
            InfoLabel.Text = "Перед настройкой приложения, потребуется подключение к интернету";
            InfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            StartButton.Location = new Point(10, 340);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(280, 50);
            StartButton.TabIndex = 3;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 401);
            Controls.Add(StartButton);
            Controls.Add(InfoLabel);
            Controls.Add(WelcomeLabel);
            Controls.Add(InitializeLabel);
            Name = "EntryForm";
            Text = "Инициализация";
            ResumeLayout(false);
        }

        #endregion

        private Label InitializeLabel;
        private Label WelcomeLabel;
        private Label InfoLabel;
        private Button StartButton;
    }
}