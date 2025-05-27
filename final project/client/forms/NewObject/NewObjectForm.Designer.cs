namespace client.forms.NewObject {
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
            DescriptionLabel = new Label();
            ObjectTypeInput = new TextBox();
            LocationLabel = new Label();
            DescriptionInput = new TextBox();
            NumberLabel = new Label();
            LocationInput = new TextBox();
            ObjectTypeLabel = new Label();
            NumberInput = new TextBox();
            SuspendLayout();
            // 
            // CreateButton
            // 
            resources.ApplyResources(CreateButton, "CreateButton");
            CreateButton.Name = "CreateButton";
            CreateButton.UseVisualStyleBackColor = true;
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
            // DescriptionLabel
            // 
            resources.ApplyResources(DescriptionLabel, "DescriptionLabel");
            DescriptionLabel.Name = "DescriptionLabel";
            // 
            // ObjectTypeInput
            // 
            resources.ApplyResources(ObjectTypeInput, "ObjectTypeInput");
            ObjectTypeInput.Name = "ObjectTypeInput";
            // 
            // LocationLabel
            // 
            resources.ApplyResources(LocationLabel, "LocationLabel");
            LocationLabel.Name = "LocationLabel";
            // 
            // DescriptionInput
            // 
            resources.ApplyResources(DescriptionInput, "DescriptionInput");
            DescriptionInput.Name = "DescriptionInput";
            // 
            // NumberLabel
            // 
            resources.ApplyResources(NumberLabel, "NumberLabel");
            NumberLabel.Name = "NumberLabel";
            // 
            // LocationInput
            // 
            resources.ApplyResources(LocationInput, "LocationInput");
            LocationInput.Name = "LocationInput";
            // 
            // ObjectTypeLabel
            // 
            resources.ApplyResources(ObjectTypeLabel, "ObjectTypeLabel");
            ObjectTypeLabel.Name = "ObjectTypeLabel";
            // 
            // NumberInput
            // 
            resources.ApplyResources(NumberInput, "NumberInput");
            NumberInput.Name = "NumberInput";
            // 
            // NewObjectForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NumberInput);
            Controls.Add(ObjectTypeLabel);
            Controls.Add(LocationInput);
            Controls.Add(NumberLabel);
            Controls.Add(DescriptionInput);
            Controls.Add(LocationLabel);
            Controls.Add(ObjectTypeInput);
            Controls.Add(DescriptionLabel);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(CreateLabel);
            Controls.Add(CancelButton);
            Controls.Add(CreateButton);
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
        private Label DescriptionLabel;
        private TextBox ObjectTypeInput;
        private Label LocationLabel;
        private TextBox DescriptionInput;
        private Label NumberLabel;
        private TextBox LocationInput;
        private Label ObjectTypeLabel;
        private TextBox NumberInput;
    }
}