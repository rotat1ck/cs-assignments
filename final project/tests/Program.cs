using SqliteDB;
using client.models.data;

class Code {
    static void Main() {
        Database db = new("client.db");
        Users usersModel = new Users(db);

        List<Users> users = usersModel.Filter(("id", "5"));

        foreach (var user in users) {
            Console.WriteLine($"{user.id} + {user.username}");
        }
    }
}