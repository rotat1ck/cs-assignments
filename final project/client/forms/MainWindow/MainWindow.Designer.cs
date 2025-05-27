namespace client {
    partial class MainWindow {
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
        private void InitializeComponent()
        {
            NewObjectButton = new Button();
            ObjectsLabel = new Label();
            ObjectsLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(12, 376);
            NewObjectButton.Name = "NewObjectButton";
            NewObjectButton.Size = new Size(124, 30);
            NewObjectButton.TabIndex = 3;
            NewObjectButton.Text = "New object";
            NewObjectButton.UseVisualStyleBackColor = true;
            NewObjectButton.Click += NewObjectButton_Click;
            // 
            // ObjectsLabel
            // 
            ObjectsLabel.AutoSize = true;
            ObjectsLabel.Location = new Point(12, 9);
            ObjectsLabel.Name = "ObjectsLabel";
            ObjectsLabel.Size = new Size(47, 15);
            ObjectsLabel.TabIndex = 5;
            ObjectsLabel.Text = "Objects";
            // 
            // ObjectsLayout
            // 
            ObjectsLayout.ColumnCount = 2;
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ObjectsLayout.Location = new Point(12, 27);
            ObjectsLayout.Name = "ObjectsLayout";
            ObjectsLayout.RowCount = 1;
            ObjectsLayout.RowStyles.Add(new RowStyle());
            ObjectsLayout.Size = new Size(368, 343);
            ObjectsLayout.TabIndex = 6;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 418);
            Controls.Add(ObjectsLayout);
            Controls.Add(ObjectsLabel);
            Controls.Add(NewObjectButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewObjectButton;
        private Label ObjectsLabel;
        private TableLayoutPanel ObjectsLayout;
    }
}