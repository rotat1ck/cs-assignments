namespace client.forms.Modals.NewObject {
    partial class NewObjectForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewObjectForm));
            CreateButton = new Button();
            CancelButton = new Button();
            CreateLabel = new Label();
            NameLabel = new Label();
            NameInput = new TextBox();
            DescriptionInput = new TextBox();
            LocationInput = new TextBox();
            NumberInput = new TextBox();
            ObjectTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(CreateButton, "CreateButton");
            CreateButton.Name = "CreateButton";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // CancelButton
            // 
            resources.ApplyResources(CancelButton, "CancelButton");
            CancelButton.Name = "CancelButton";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateLabel
            // 
            resources.ApplyResources(CreateLabel, "CreateLabel");
            CreateLabel.Name = "CreateLabel";
            // 
            // NameLabel
            // 
            resources.ApplyResources(NameLabel, "NameLabel");
            NameLabel.Name = "NameLabel";
            // 
            // NameInput
            // 
            resources.ApplyResources(NameInput, "NameInput");
            NameInput.Name = "NameInput";
            // 
            // DescriptionInput
            // 
            resources.ApplyResources(DescriptionInput, "DescriptionInput");
            DescriptionInput.Name = "DescriptionInput";
            // 
            // LocationInput
            // 
            resources.ApplyResources(LocationInput, "LocationInput");
            LocationInput.Name = "LocationInput";
            // 
            // NumberInput
            // 
            resources.ApplyResources(NumberInput, "NumberInput");
            NumberInput.Name = "NumberInput";
            // 
            // ObjectTypeComboBox
            // 
            resources.ApplyResources(ObjectTypeComboBox, "ObjectTypeComboBox");
            ObjectTypeComboBox.Name = "ObjectTypeComboBox";
            ObjectTypeComboBox.KeyDown += ObjectTypeComboBox_KeyDown;
            // 
            // NewObjectForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ObjectTypeComboBox);
            Controls.Add(NumberInput);
            Controls.Add(LocationInput);
            Controls.Add(DescriptionInput);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(CreateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewObjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateButton;
        private Button CancelButton;
        private Label CreateLabel;
        private Label NameLabel;
        private TextBox NameInput;
        private TextBox DescriptionInput;
        private TextBox LocationInput;
        private TextBox NumberInput;
        private ComboBox ObjectTypeComboBox;
    }
}