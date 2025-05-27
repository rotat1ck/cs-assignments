using System.Windows.Forms;
using SqliteDB;

namespace client
{
    public partial class MainWindow : Form
    {
        private DBController controller = new("client.db");
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void NewObjectButton_Click(object sender, EventArgs e) {
            controller.objectsModel.CreateRecord(new Objects
            {
                object_type = 1,
                name = "Meow 3",
                description = "Goida Description",
                location = "Goida Street",
                number = 123
            });
        }

        private void UpdateObjectsLayout() {
            ObjectsLayout.Controls.Clear();
            List<Objects> objects = controller.objectsModel.Query();

            foreach (Objects obj in objects) {
                Button objButton = new Button {
                    Size = new Size(240, 30),
                    Text = obj.name + ", " + obj.number
                };
                ObjectsLayout.Controls.Add(objButton);

                Button deleteButton = new Button {
                    Size = new Size(75, 30),
                    Text = "Delete",
                    Tag = obj
                };

                deleteButton.Click += (s, e) => {
                    ObjectsLayout.Controls.Remove(objButton);
                    ObjectsLayout.Controls.Remove(deleteButton);
                    controller.objectsModel.DeleteRecord(obj);
                };
                ObjectsLayout.Controls.Add(deleteButton);
            }
        }
    }
}
