namespace client.forms.Helper {
    partial class DownloadForm {
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
            DownloadLabel = new Label();
            DownloadProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // DownloadLabel
            // 
            DownloadLabel.Font = new Font("Segoe UI", 12F);
            DownloadLabel.Location = new Point(12, 9);
            DownloadLabel.Name = "DownloadLabel";
            DownloadLabel.Size = new Size(215, 50);
            DownloadLabel.TabIndex = 0;
            DownloadLabel.Text = "Идет установка, пожалуйста подождите";
            // 
            // DownloadProgressBar
            // 
            DownloadProgressBar.Location = new Point(12, 71);
            DownloadProgressBar.Name = "DownloadProgressBar";
            DownloadProgressBar.Size = new Size(215, 30);
            DownloadProgressBar.TabIndex = 1;
            // 
            // DownloadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 127);
            Controls.Add(DownloadProgressBar);
            Controls.Add(DownloadLabel);
            MaximumSize = new Size(255, 166);
            MinimumSize = new Size(255, 166);
            Name = "DownloadForm";
            Text = "Установка";
            ResumeLayout(false);
        }

        #endregion

        public Label DownloadLabel;
        public ProgressBar DownloadProgressBar;
    }
}