using SqliteDB;
using client.models.data;

class Code {
    static void Main() {
        Database db = new("client.db");
        Users usersModel = new Users(db);

        Users user = usersModel.Filter(5);
        user.username = "123123123";
        user.email = """""'; DELETE * FROM users --"""";
        user.password = "goidaaa";

        user.Commit();
    }
}