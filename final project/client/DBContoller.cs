using SqliteDB;
using client.models.data;
using client.models.linking;

namespace client {
    internal class DBController {
        public Database db;
        public Objects objectsModel;

        public DBController(string dbPath) {
            InitDB(dbPath);
        }

        private void InitDB(string dbPath) {
            try {
                this.db = new Database(dbPath);
                
            } catch (Exception ex) {
                // Call "cherry.rotatick.ru/db-sample"
                // Add returned file next to executable
                throw new NotImplementedException();
            }

            this.objectsModel = new Objects(db);
        }
    }
}
