using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using client.forms.Modals.LinkDocument;
using client.forms.Modals.LinkPhoto;
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
        private ComboBox employeeInput;
        private TextBox numberInput;
        private TextBox nameInput;
        private bool isObjectChosen;

        Objects currentObject;
        Tasks currentTask;
        Tasks_Objects currentTaskLink;

        public ObjectsManagementForm() {
            InitializeComponent();
            UpdateObjectsLayout();

            if (DBController.currentUser.rights < 1) {
                NewObjectButton.Visible = false;
            }
        }

        private void TasksYoursCheckBox_Changed(object sender, EventArgs e) {
            ObjectButton_Click(currentObject);
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

        private void NewDocumentButton_Click(object sender, EventArgs e) {
            using (LinkDocumentForm form = new LinkDocumentForm(currentObject)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    DBController.documents_ObjectsModel.CreateRecord(form.link);
                    ObjectButton_Click(currentObject);
                }
            }
        }

        private void NewPhotoButton_Click(object sender, EventArgs e) {
            using (LinkPhotoForm form = new LinkPhotoForm(currentObject)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    DBController.photos_ObjectsModel.CreateRecord(form.link);
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
                currentTaskLink.employee_id = ((Employees)employeeInput.SelectedItem).id;

                DBController.tasksModel.UpdateRecord(currentTask);
                DBController.tasks_ObjectsModel.UpdateRecord(currentTaskLink);
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
            TasksYoursCheckBox.Visible = true;

            DocumentsLabel.Visible = true;
            DocumentsLayout.Visible = true;

            PhotosLabel.Visible = true;
            PhotosLayout.Visible = true;

            if (DBController.currentUser.rights > 0) {
                SaveObjectInfoButton.Visible = true;
                NewTaskButton.Visible = true;
                NewDocumentButton.Visible = true;
                NewPhotoButton.Visible = true;
            }

            ChosenInfoLayout.Controls.Clear();
            TasksLayout.Controls.Clear();
            DocumentsLayout.Controls.Clear();
            PhotosLayout.Controls.Clear();

            ObjectButton_Fill(obj);

            // заполнение задач
            List<Tasks_Objects> linkedTasks = DBController.tasks_ObjectsModel.Filter(("object_id", obj.id));
            if (TasksYoursCheckBox.Checked) {
                linkedTasks = DBController.tasks_ObjectsModel.Filter(("object_id", obj.id), ("employee_id", DBController.currentUser.employee_id));
            }
            foreach (var tasksId in linkedTasks) {
                Tasks task = DBController.tasksModel.Filter(tasksId.task_id);

                Button taskButton = new Button {
                    Size = new Size(140, 30),
                    Text = task.name
                };
                taskButton.Click += (s, e) => TaskButton_Click(task, tasksId);
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

            // заполнение документов
            List<Documents_Objects> linkedDocuments = DBController.documents_ObjectsModel.Filter(("object_id", obj.id));
            foreach (var documentId in linkedDocuments) {
                Documents document = DBController.documentsModel.Filter(documentId.document_id);

                LinkLabel linkLabel = new LinkLabel {
                    Size = new Size(65, 30),
                    Text = document.name,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                linkLabel.LinkClicked += (s, e) => {
                    var funSystemCall100PercentNotRemoteShell = new ProcessStartInfo {
                        FileName = document.link,
                        UseShellExecute = true
                    };
                    try {
                        Process.Start(funSystemCall100PercentNotRemoteShell);
                    } catch (Win32Exception) {
                        MessageBox.Show($"Не удалось перейти по: {document.link}");
                    }
                };
                DocumentsLayout.Controls.Add(linkLabel);

                Button deleteButton = new Button {
                    Size = new Size(65, 30),
                    Text = "Отвязать",
                    TextAlign = ContentAlignment.MiddleLeft
                };

                deleteButton.Click += (s, e) => {
                    DocumentsLayout.Controls.Remove(linkLabel);
                    DocumentsLayout.Controls.Remove(deleteButton);
                    DBController.documents_ObjectsModel.DeleteRecord(documentId);
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                DocumentsLayout.Controls.Add(deleteButton);
            }

            // заполнение фото
            List<Photos_Objects> linkedPhotos = DBController.photos_ObjectsModel.Filter(("object_id", obj.id));
            foreach (var photoId in linkedPhotos) {
                Photos photo = DBController.photosModel.Filter(photoId.photo_id);

                LinkLabel linkLabel = new LinkLabel {
                    Size = new Size(65, 30),
                    Text = photo.name,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                linkLabel.LinkClicked += (s, e) => {
                    var funSystemCall100PercentNotRemoteShell = new ProcessStartInfo {
                        FileName = photo.link,
                        UseShellExecute = true
                    };
                    try {
                        Process.Start(funSystemCall100PercentNotRemoteShell);
                    } catch (Win32Exception) {
                        MessageBox.Show($"Не удалось перейти по: {photo.link}");
                    }
                };
                PhotosLayout.Controls.Add(linkLabel);

                Button deleteButton = new Button {
                    Size = new Size(65, 30),
                    Text = "Отвязать",
                    TextAlign = ContentAlignment.MiddleLeft
                };

                deleteButton.Click += (s, e) => {
                    PhotosLayout.Controls.Remove(linkLabel);
                    PhotosLayout.Controls.Remove(deleteButton);
                    DBController.photos_ObjectsModel.DeleteRecord(photoId);
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                PhotosLayout.Controls.Add(deleteButton);
            }
        }

        private void TaskButton_Click(Tasks task, Tasks_Objects taskLink) {
            ChosenInfoLayout.Controls.Clear();

            isObjectChosen = false;
            currentTask = task;
            currentTaskLink = taskLink;
            ChosenInfoLabel.Text = "Информация о задаче";

            // Дедлайн
            Label deadlineLabel = new Label {
                Text = "Исполнить до: " + DateTimeOffset.FromUnixTimeSeconds(currentTaskLink.endstamp).LocalDateTime.ToLongDateString(),
                Dock = DockStyle.Top
            };
            ChosenInfoLayout.Controls.Add(deadlineLabel);

            // Исполнитель
            employeeInput = new ComboBox {
                DisplayMember = "last_name",
                ValueMember = "id",
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Top
            };
            foreach (var item in DBController.employeesModel.Query()) {
                employeeInput.Items.Add(item);
                if (item.id == taskLink.employee_id) {
                    employeeInput.SelectedItem = item;
                }
            }
            ChosenInfoLayout.Controls.Add(employeeInput);

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
