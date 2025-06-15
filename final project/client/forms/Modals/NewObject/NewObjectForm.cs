using client.models.data;
using client.models.linking;

namespace client.forms.Modals.NewObject {
    public partial class NewObjectForm : Form {
        public Objects NewObject { get; private set; }

        public NewObjectForm() {
            InitializeComponent();
            ObjectTypeComboBox.DataSource = DBController.objects_TypesModel.Query();
            ObjectTypeComboBox.DisplayMember = "name";
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            var objectType = (Objects_Types)ObjectTypeComboBox.SelectedItem;
            NewObject = new Objects {
                object_type = objectType.id,
                name = NameInput.Text,
                description = DescriptionInput.Text,
                location = LocationInput.Text,
                number = int.Parse(NumberInput.Text)
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
