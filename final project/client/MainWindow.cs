using SqliteDB;

namespace client {
    public partial class MainWindow : Form {
        private DBController controller = new DBController("client.db");
        public MainWindow() {
            InitializeComponent();

            controller.objectsModel.CreateRecord(new Objects {
                object_type = 1,
                name = "Goida House",
                description = "Goida Description",
                location = "Goida Street",
                number = 1
            });
            List<Objects> objects = controller.objectsModel.Query();
            dataGridView1.DataSource = objects;
        }
    }
}
