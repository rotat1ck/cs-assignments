using System.Data;

static class ModelsTest {
    public static void Test(Database db) {
        Objects objectsModel = new Objects(db);
        Users usersModel = new Users(db);

        List<Objects> objects = objectsModel.Query();
        foreach (Objects obj in objects) {
            Console.WriteLine(obj.name + obj.description + obj.location);
        }

        List<Users> users = usersModel.Query();
        foreach (Users user in users) {
            Console.WriteLine($"User {user.id}, {user.username}, {user.email}");
        }
    }
}