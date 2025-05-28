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
        private void InitializeComponent() {
            NewObjectButton = new Button();
            ObjectsLabel = new Label();
            ObjectsLayout = new TableLayoutPanel();
            panel1 = new Panel();
            collapsibleSidebar1 = new forms.MainWindow.CollapsibleSidebar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(78, 400);
            NewObjectButton.Margin = new Padding(3, 4, 3, 4);
            NewObjectButton.Name = "NewObjectButton";
            NewObjectButton.Size = new Size(142, 40);
            NewObjectButton.TabIndex = 3;
            NewObjectButton.Text = "New object";
            NewObjectButton.UseVisualStyleBackColor = true;
            NewObjectButton.Click += NewObjectButton_Click;
            // 
            // ObjectsLabel
            // 
            ObjectsLabel.AutoSize = true;
            ObjectsLabel.Location = new Point(78, 9);
            ObjectsLabel.Name = "ObjectsLabel";
            ObjectsLabel.Size = new Size(59, 20);
            ObjectsLabel.TabIndex = 5;
            ObjectsLabel.Text = "Objects";
            // 
            // ObjectsLayout
            // 
            ObjectsLayout.ColumnCount = 2;
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ObjectsLayout.Location = new Point(78, 33);
            ObjectsLayout.Margin = new Padding(3, 4, 3, 4);
            ObjectsLayout.Name = "ObjectsLayout";
            ObjectsLayout.RowCount = 1;
            ObjectsLayout.RowStyles.Add(new RowStyle());
            ObjectsLayout.Size = new Size(421, 335);
            ObjectsLayout.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(collapsibleSidebar1);
            panel1.Controls.Add(ObjectsLabel);
            panel1.Controls.Add(NewObjectButton);
            panel1.Controls.Add(ObjectsLayout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 453);
            panel1.TabIndex = 8;
            // 
            // collapsibleSidebar1
            // 
            collapsibleSidebar1.AutoSize = false;
            collapsibleSidebar1.BackColor = Color.FromArgb(50, 50, 50);
            collapsibleSidebar1.Dock = DockStyle.Left;
            collapsibleSidebar1.ForeColor = Color.White;
            collapsibleSidebar1.ImageScalingSize = new Size(20, 20);
            collapsibleSidebar1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            collapsibleSidebar1.Location = new Point(0, 0);
            collapsibleSidebar1.Name = "collapsibleSidebar1";
            collapsibleSidebar1.Size = new Size(62, 453);
            collapsibleSidebar1.TabIndex = 7;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "MainWindow";
            Text = "MainWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button NewObjectButton;
        private Label ObjectsLabel;
        private TableLayoutPanel ObjectsLayout;
        private Panel panel1;
        private forms.MainWindow.CollapsibleSidebar collapsibleSidebar1;
    }
}