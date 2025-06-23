namespace client.forms.Modals.LinkTask {
    partial class LinkTaskForm {
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
            TasksList = new ComboBox();
            ChooseLabel = new Label();
            SearchLabel = new Label();
            SearchInput = new TextBox();
            CancelButton = new Button();
            LinkButton = new Button();
            label1 = new Label();
            Endstamp = new DateTimePicker();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // TasksList
            // 
            TasksList.FormattingEnabled = true;
            TasksList.Location = new Point(12, 44);
            TasksList.Name = "TasksList";
            TasksList.Size = new Size(310, 23);
            TasksList.TabIndex = 0;
            TasksList.SelectedIndexChanged += TasksList_Update;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Location = new Point(12, 9);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(156, 15);
            ChooseLabel.TabIndex = 1;
            ChooseLabel.Text = "Выберите задачу из списка";
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(51, 136);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(54, 15);
            SearchLabel.TabIndex = 2;
            SearchLabel.Text = "Поиск🔎";
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(111, 133);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(211, 23);
            SearchInput.TabIndex = 3;
            SearchInput.KeyDown += SearchInput_KeyDown;
            // 
            // CancelButton
            // 
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(12, 194);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 35);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // LinkButton
            // 
            LinkButton.BackColor = Color.FromArgb(192, 255, 192);
            LinkButton.ImeMode = ImeMode.NoControl;
            LinkButton.Location = new Point(192, 194);
            LinkButton.Name = "LinkButton";
            LinkButton.Size = new Size(130, 35);
            LinkButton.TabIndex = 4;
            LinkButton.Text = "Привязать";
            LinkButton.UseVisualStyleBackColor = false;
            LinkButton.Click += LinkButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 162);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Исполнить до:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Endstamp
            // 
            Endstamp.Location = new Point(111, 162);
            Endstamp.MinDate = new DateTime(2025, 6, 15, 20, 39, 58, 0);
            Endstamp.Name = "Endstamp";
            Endstamp.Size = new Size(211, 23);
            Endstamp.TabIndex = 7;
            Endstamp.Value = new DateTime(2025, 6, 15, 20, 39, 58, 0);
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Location = new Point(12, 70);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(310, 60);
            DescriptionLabel.TabIndex = 8;
            // 
            // LinkTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 241);
            Controls.Add(DescriptionLabel);
            Controls.Add(Endstamp);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(LinkButton);
            Controls.Add(SearchInput);
            Controls.Add(SearchLabel);
            Controls.Add(ChooseLabel);
            Controls.Add(TasksList);
            MaximumSize = new Size(350, 280);
            MinimumSize = new Size(350, 280);
            Name = "LinkTaskForm";
            Text = "Привязать задачу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TasksList;
        private Label ChooseLabel;
        private Label SearchLabel;
        private TextBox SearchInput;
        private Button CancelButton;
        private Button LinkButton;
        private Label label1;
        private DateTimePicker Endstamp;
        private Label DescriptionLabel;
    }
}