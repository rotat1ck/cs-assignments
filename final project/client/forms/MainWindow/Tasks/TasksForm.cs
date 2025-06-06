using client.models.data;
using client.forms.Modals.NewTask;

namespace client.forms.MainWindow
{
    public partial class TasksForm : Form {
        public TasksForm() {
            InitializeComponent();
            UpdateTasksList();
        }

        private void UpdateTasksList() {
            TasksLayout.Controls.Clear();
            List<Tasks> tasks = DBController.tasksModel.Query();

            foreach (Tasks task in tasks) {
                Button taskButton = new Button {
                    Size = new Size(200, 30),
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
                    Text = "Delete"
                };

                deleteButton.Click += (s, e) => {
                    TasksLayout.Controls.Remove(taskButton);
                    TasksLayout.Controls.Remove(deleteButton);
                    DBController.tasksModel.DeleteRecord(task);
                };
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
