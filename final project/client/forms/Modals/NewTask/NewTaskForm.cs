using client.models.data;

namespace client.forms.Modals.NewTask {
    public partial class NewTaskForm : Form {
        public Tasks Task;
        public NewTaskForm() {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            Task = new Tasks {
                name = NameInput.Text,
                content = ContentInput.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
