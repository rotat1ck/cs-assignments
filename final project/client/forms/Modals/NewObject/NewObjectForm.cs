using client.models.data;
using client.models.linking;

namespace client.forms.Modals.NewObject {
    public partial class NewObjectForm : Form {
        public Objects NewObject { get; private set; }

        public NewObjectForm() {
            InitializeComponent();
            ObjectTypeComboBox_Fill();
        }

        private void ObjectTypeComboBox_Fill() {
            ObjectTypeComboBox.DataSource = DBController.objects_TypesModel.Query();
            ObjectTypeComboBox.DisplayMember = "name";
        }

        private void ObjectTypeComboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && ObjectTypeComboBox.Text != "") {
                List<Objects_Types> objectsTypes = DBController.objects_TypesModel.Filter(("name", ObjectTypeComboBox.Text));
                if (objectsTypes.Count == 0) {
                    DBController.objects_TypesModel.CreateRecord(new Objects_Types {
                        name = ObjectTypeComboBox.Text,
                    });
                    ObjectTypeComboBox_Fill();
                    ObjectTypeComboBox.SelectedItem = DBController.objects_TypesModel.Filter(("name", ObjectTypeComboBox.Text))[0];
                }
            }
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
