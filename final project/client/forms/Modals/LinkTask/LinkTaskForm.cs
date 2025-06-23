using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.models.data;
using client.models.linking;

namespace client.forms.Modals.LinkTask {
    public partial class LinkTaskForm : Form {
        private Objects obj;
        public Tasks_Objects newLink;

        public LinkTaskForm(Objects obj) {
            this.obj = obj;
            InitializeComponent();
            TasksList_Fill();
            Endstamp.MinDate = DateTime.Now;
            Endstamp.Value = DateTime.Now;
        }

        private void TasksList_Fill() {
            TasksList.Items.Clear();
            TasksList.Text = "";
            DescriptionLabel.Text = "";

            List<Tasks_Objects> allObjLinkings = DBController.tasks_ObjectsModel.Query().Where(linking => linking.object_id == obj.id).ToList();
            List<Tasks> allTasks;

            if (SearchInput.Text.Trim() != "") {
                allTasks = DBController.tasksModel.Filter(("name", SearchInput.Text.Trim()));
            } else {
                allTasks = DBController.tasksModel.Query();
            }

            foreach (Tasks task in allTasks) {
                if (allObjLinkings.Any(linking => linking.task_id == task.id)) {
                    continue;
                }
                TasksList.Items.Add(task);
            }
            TasksList.DisplayMember = "name";
            if (TasksList.Items.Count > 0) {
                TasksList.SelectedIndex = 0;
                DescriptionLabel.Text = ((Tasks)TasksList.SelectedItem).content;
            }
        }

        private void TasksList_Update(object sender, EventArgs e) {
            DescriptionLabel.Text = ((Tasks)TasksList.SelectedItem).content;
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                TasksList_Fill();
        }

        private void LinkButton_Click(object sender, EventArgs e) {
            if (TasksList.SelectedItem != null) {
                newLink = new Tasks_Objects {
                    endstamp = (int)((DateTimeOffset)Endstamp.Value).ToUnixTimeSeconds(),
                    object_id = obj.id,
                    task_id = ((Tasks)TasksList.SelectedItem).id
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("Выберите задачу из выпадающего списка");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
