using System.Data;

static class ModelsTest {
    public static void Test(Database db) {
        Objects objectsModel = new Objects(db);
        Users usersModel = new Users(db);

        Console.WriteLine("Query test: ");

        List<Objects> objects = objectsModel.Query();
        foreach (Objects obj in objects) {
            Console.WriteLine($"House {obj.name}, {obj.description}, {obj.location}");
        }

        List<Users> users = usersModel.Query();
        foreach (Users user in users) {
            Console.WriteLine($"User {user.id}, {user.username}, {user.email}");
        }

        Console.WriteLine("Filter test: ");

        // Фильтр по параметрам
        List<Objects> objectFiltered1 = objectsModel.Filter(("name", "Домик 1"));
        Console.WriteLine(objectFiltered1[0].id + " " + objectFiltered1[0].description);

        // Фильтр по id
        Objects objectFiltered2 = objectsModel.Filter(2);
        Console.WriteLine(objectFiltered2.name + " " + objectFiltered2.description);
    }
}