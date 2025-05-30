namespace client {
    partial class ObjectsManagementForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsManagementForm));
            TestLabel = new Label();
            NewObjectButton = new Button();
            collapsibleSidebar1 = new forms.MainWindow.CollapsibleSidebar();
            ObjectsLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.Location = new Point(273, 9);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(77, 20);
            TestLabel.TabIndex = 0;
            TestLabel.Text = "ОБЪЕКТЫ";
            // 
            // NewObjectButton
            // 
            NewObjectButton.Location = new Point(576, 392);
            NewObjectButton.Name = "NewObjectButton";
            NewObjectButton.Size = new Size(94, 49);
            NewObjectButton.TabIndex = 3;
            NewObjectButton.Text = "Новый объект";
            NewObjectButton.UseVisualStyleBackColor = true;
            NewObjectButton.Click += NewObjectButton_Click;
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
            collapsibleSidebar1.TabIndex = 4;
            collapsibleSidebar1.Text = "collapsibleSidebar1";
            // 
            // ObjectsLayout
            // 
            ObjectsLayout.BackColor = Color.Transparent;
            ObjectsLayout.ColumnCount = 2;
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            ObjectsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ObjectsLayout.Location = new Point(76, 32);
            ObjectsLayout.Name = "ObjectsLayout";
            ObjectsLayout.RowCount = 1;
            ObjectsLayout.RowStyles.Add(new RowStyle());
            ObjectsLayout.Size = new Size(494, 409);
            ObjectsLayout.TabIndex = 5;
            // 
            // ObjectsManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 453);
            Controls.Add(collapsibleSidebar1);
            Controls.Add(ObjectsLayout);
            Controls.Add(NewObjectButton);
            Controls.Add(TestLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = collapsibleSidebar1;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "ObjectsManagementForm";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TestLabel;
        private Button NewObjectButton;
        private forms.MainWindow.CollapsibleSidebar collapsibleSidebar1;
        private TableLayoutPanel ObjectsLayout;
    }
}