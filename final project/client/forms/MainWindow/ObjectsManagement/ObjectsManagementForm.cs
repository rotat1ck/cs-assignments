using client.forms.NewObject;
using client.models.data;

namespace client{
    public partial class ObjectsManagementForm : Form {
        public ObjectsManagementForm() {
            InitializeComponent();
            UpdateObjectsLayout();
        }
        private void NewObjectButton_Click(object sender, EventArgs e) {
            using (NewObjectForm objectForm = new NewObjectForm()) {
                if (objectForm.ShowDialog() == DialogResult.OK) {
                    Objects newObject = objectForm.NewObject;
                    DBController.objectsModel.CreateRecord(newObject);
                    UpdateObjectsLayout();
                }
            }
        }

        private void UpdateObjectsLayout() {
            ObjectsLayout.Controls.Clear();
            List<Objects> objects = DBController.objectsModel.Query();

            foreach (Objects obj in objects) {
                Button objButton = new Button {
                    Size = new Size(240, 30),
                    Text = obj.name + ", " + obj.number
                };
                ObjectsLayout.Controls.Add(objButton);

                Button deleteButton = new Button {
                    Size = new Size(75, 30),
                    Text = "Delete"
                };

                deleteButton.Click += (s, e) => {
                    ObjectsLayout.Controls.Remove(objButton);
                    ObjectsLayout.Controls.Remove(deleteButton);
                    DBController.objectsModel.DeleteRecord(obj);
                };
                ObjectsLayout.Controls.Add(deleteButton);
            }
        }
    }
}
