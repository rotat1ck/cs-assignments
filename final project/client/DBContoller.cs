using SqliteDB;
using client.models.data;
using client.models.linking;

namespace client {
    public static class DBController {
        public static Database db;
        public static Users? currentUser = null!;

        public static Objects objectsModel;
        public static Documents documentsModel;
        public static Photos photosModel;
        public static Tasks tasksModel;

        public static Users usersModel;
        public static Employees employeesModel;
        public static Positions positionsModel;
        public static Roles rolesModel;

        public static Documents_Objects documents_ObjectsModel;
        public static Objects_Types objects_TypesModel;
        public static Photos_Objects photos_ObjectsModel;
        public static Tasks_Objects tasks_ObjectsModel;

        public static void InitDB(string dbPath) {
            try {
                db = new Database(dbPath);
                
            } catch (Exception ex) {
                // Call "cherry.rotatick.ru/db-sample"
                // Add returned file next to executable
                throw new NotImplementedException();
            }

            objectsModel = new Objects(db);
            documentsModel = new Documents(db);
            photosModel = new Photos(db);
            tasksModel = new Tasks(db);

            usersModel = new Users(db);
            employeesModel = new Employees(db);
            positionsModel = new Positions(db);
            rolesModel = new Roles(db);

            documents_ObjectsModel = new Documents_Objects(db);
            objects_TypesModel = new Objects_Types(db);
            photos_ObjectsModel = new Photos_Objects(db);
            tasks_ObjectsModel = new Tasks_Objects(db);
        }
    }
}
