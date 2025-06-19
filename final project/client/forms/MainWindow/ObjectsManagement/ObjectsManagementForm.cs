using client.forms.Modals.LinkTask;
using client.forms.Modals.NewObject;
using client.models.data;
using client.models.linking;

namespace client {
    public partial class ObjectsManagementForm : Form {
        private TextBox descriptionInput;
        private TextBox addressInput;
        private Panel panel;
        private ComboBox typeInput;
        private TextBox numberInput;
        private TextBox nameInput;
        private bool isObjectChosen;

        Objects currentObject;
        Tasks currentTask;

        public ObjectsManagementForm() {
            InitializeComponent();
            UpdateObjectsLayout();

            if (DBController.currentUser.rights < 1) {
                NewObjectButton.Visible = false;
            }
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

        private void NewTaskButton_Click(object sender, EventArgs e) {
            using (LinkTaskForm taskForm = new LinkTaskForm(currentObject)) {
                if (taskForm.ShowDialog() == DialogResult.OK) {
                    Tasks_Objects newLink = taskForm.newLink;
                    DBController.tasks_ObjectsModel.CreateRecord(newLink);
                    ObjectButton_Click(currentObject);
                }
            }
        }

        private void SaveObjectInfoButton_Click(object sender, EventArgs e) {
            if (isObjectChosen) {
                currentObject.object_type = ((Objects_Types)typeInput.SelectedItem).id;
                currentObject.name = nameInput.Text;
                currentObject.description = descriptionInput.Text;
                currentObject.location = addressInput.Text;
                  currentObject.number = int.Parse(numberInput.Text);

                DBController.objectsModel.UpdateRecord(currentObject);
            } else {
                currentTask.name = nameInput.Text;
                currentTask.content = descriptionInput.Text;

                DBController.tasksModel.UpdateRecord(currentTask);
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
                    Text = "Удалить"
                };

                deleteButton.Click += (s, e) => {
                    ObjectsLayout.Controls.Remove(objButton);
                    ObjectsLayout.Controls.Remove(deleteButton);
                    DBController.objectsModel.DeleteRecord(obj);
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                ObjectsLayout.Controls.Add(deleteButton);
                
            }
        }
        private void ObjectButton_Click(Objects obj) {
            isObjectChosen = true;
            currentObject = obj;

            ChosenInfoLabel.Visible = true;
            ChosenInfoLabel.Text = "Информация об объекте";
            ChosenInfoLayout.Visible = true;

            TasksLabel.Visible = true;
            TasksLayout.Visible = true;

            if (DBController.currentUser.rights > 0) {
                SaveObjectInfoButton.Visible = true;
                NewTaskButton.Visible = true;
            }

            ChosenInfoLayout.Controls.Clear();
            TasksLayout.Controls.Clear();

            ObjectButton_Fill(obj);

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
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                TasksLayout.Controls.Add(deleteButton);
            }
        }

        private void TaskButton_Click(Tasks task) {
            ChosenInfoLayout.Controls.Clear();
            NewTaskButton.Visible = false;

            isObjectChosen = false;
            currentTask = task;
            ChosenInfoLabel.Text = "Информация о задаче";

            // Описание
            descriptionInput = new TextBox {
                Text = task.content,
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
                Dock = DockStyle.Top,
                Multiline = true,
                Height = 100
            };
            ChosenInfoLayout.Controls.Add(descriptionInput);

            // Название
            nameInput = new TextBox {
                Text = task.name,
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
                Dock = DockStyle.Top
            };
            ChosenInfoLayout.Controls.Add(nameInput);
        }

        private void ObjectButton_Fill(Objects obj) {
            // Описание
            descriptionInput = new TextBox {
                Text = obj.description,
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
                Dock = DockStyle.Top,
                Multiline = true,
                Height = 100
            };
            ChosenInfoLayout.Controls.Add(descriptionInput);

            // Адрес
            addressInput = new TextBox {
                Text = obj.location,
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
                Dock = DockStyle.Top
            };
            ChosenInfoLayout.Controls.Add(addressInput);

            // Тип и номер
            panel = new FlowLayoutPanel {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Dock = DockStyle.Top
            };

            typeInput = new ComboBox {
                DisplayMember = "name",
                ValueMember = "id",
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            foreach (var item in DBController.objects_TypesModel.Query()) {
                typeInput.Items.Add(item);
                if (item.id == obj.object_type) {
                    typeInput.SelectedItem = item;
                }
            }

            numberInput = new TextBox {
                Text = obj.number.ToString(),
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
            };
            panel.Controls.Add(typeInput);
            panel.Controls.Add(numberInput);
            ChosenInfoLayout.Controls.Add(panel);

            // Название
            nameInput = new TextBox {
                Text = obj.name,
                ReadOnly = true ? DBController.currentUser.rights < 1 : false,
                Dock = DockStyle.Top
            };
            ChosenInfoLayout.Controls.Add(nameInput);
        }
    }
}
