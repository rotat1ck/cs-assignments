using client.models.data;
using client.forms.Modals.NewTask;
using client.models.linking;

namespace client.forms.MainWindow
{
    public partial class TasksForm : Form {
        public TasksForm() {
            InitializeComponent();
            UpdateTasksList();

            if (DBController.currentUser.rights < 1) {
                NewTaskButton.Visible = false;
            }
        }

        private void UpdateTasksList() {
            TasksLayout.Controls.Clear();
            List<Tasks> tasks = DBController.tasksModel.Query();

            foreach (Tasks task in tasks) {
                Button taskButton = new Button {
                    Size = new Size(250, 30),
                    Text = task.name
                };
                taskButton.Click += (s, e) => {
                    CurrentTaskLabel.Visible = true;
                    CurrentTaskLayout.Visible = true;

                    CurrentTaskName.Text = task.name;
                    CurrentTaskContent.Text = task.content;
                };
                TasksLayout.Controls.Add(taskButton);

                Button deleteButton = new Button {
                    Size = new Size(75, 30),
                    Text = "Удалить"
                };

                deleteButton.Click += (s, e) => {
                    TasksLayout.Controls.Remove(taskButton);
                    TasksLayout.Controls.Remove(deleteButton);
                    DBController.tasksModel.DeleteRecord(task);
                    List<Tasks_Objects> linkedObjects = DBController.tasks_ObjectsModel.Filter(("task_id", task.id));
                    foreach (Tasks_Objects link in linkedObjects) {
                        DBController.tasks_ObjectsModel.DeleteRecord(link);
                    }
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                TasksLayout.Controls.Add(deleteButton);
            }
        }

        private void NewTaskButton_Click(object sender, EventArgs e) {
            using (NewTaskForm taskForm = new NewTaskForm()) {
                if (taskForm.ShowDialog() == DialogResult.OK) {
                    Tasks newTask = taskForm.Task;
                    DBController.tasksModel.CreateRecord(newTask);
                    UpdateTasksList();
                }
            }
        }
    }
}
