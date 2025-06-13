using client.forms.Modals.NewObject;
using client.models.data;
using client.models.linking;

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
                    Text = obj.name
                };

                objButton.Click += (s, e) => ObjectButton_Click(obj);
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

        private void ObjectButton_Click(Objects obj) {
            ObjectInfoLabel.Visible = true;
            ObjectInfoLabel.Visible = true;

            TasksLabel.Visible = true;
            TasksLayout.Visible = true;

            List<Tasks_Objects> linkedTasks = DBController.tasks_ObjectsModel.Filter(("object_id", obj.id));
            foreach (var tasksId in linkedTasks) {
                Tasks task = DBController.tasksModel.Filter(tasksId.task_id);

                Button taskButton = new Button {
                    Size = new Size(180, 30),
                    Text = task.name
                };
                taskButton.Click += (s, e) => TaskButton_Click(task);
                TasksLayout.Controls.Add(taskButton);

                Button deleteButton = new Button {
                    Size = new Size(65, 30),
                    Text = "Отвязать"
                };

                deleteButton.Click += (s, e) => {
                    TasksLayout.Controls.Remove(taskButton);
                    TasksLayout.Controls.Remove(deleteButton);
                    DBController.tasks_ObjectsModel.DeleteRecord(tasksId);
                };
                TasksLayout.Controls.Add(deleteButton);
            }
        }

        private void TaskButton_Click(Tasks task) {
            throw new NotImplementedException();
        }
    }
}
