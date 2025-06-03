using SqliteDB;
using client.models.data;

class Code {
    static void Main() {
        Database db = new("client.db");
        Users usersModel = new Users(db);

        Users user = new Users {
            employee_id = 1,
            username = "rotatick",
            password = "' DELETE * FROM users --",
            email = "goida@gmail.com"
        };

        usersModel.CreateRecord(user);
    }
}