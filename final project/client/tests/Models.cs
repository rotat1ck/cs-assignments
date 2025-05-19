using System.Data;

static class ModelsTest {
    public static void Test(Database db) {
        Objects objectsModel = new Objects(db);
        Users usersModel = new Users(db);

        TestQuery(objectsModel, usersModel);
        TestFilter(objectsModel);
    }

    public static void TestQuery(Objects objectsModel, Users usersModel) {
        Console.WriteLine("Query test: ");

        List<Objects> objects = objectsModel.Query();
        foreach (Objects obj in objects) {
            Console.WriteLine($"House {obj.name}, {obj.description}, {obj.location}");
        }

        List<Users> users = usersModel.Query();
        foreach (Users user in users) {
            Console.WriteLine($"User {user.id}, {user.username}, {user.email}");
        }
    }

    public static void TestFilter(Objects objectsModel) {
        Console.WriteLine("Filter test: ");

        // Фильтр по параметрам
        List<Objects> objectFiltered1 = objectsModel.Filter(("name", "Домик 1"));
        Console.WriteLine($"Params filter: {objectFiltered1[0].id}, {objectFiltered1[0].description}");

        // Фильтр по id
        Objects objectFiltered2 = objectsModel.Filter(2);
        Console.WriteLine($"Id filter: {objectFiltered2.name}, {objectFiltered2.description}");

        // Фильтр first и last
        Objects objectFirst = objectsModel.FilterFirst();
        Console.WriteLine($"FilterFirst: {objectFirst.id}, {objectFirst.description}");

        Objects objectLast = objectsModel.FilterLast();
        Console.WriteLine($"FilterLast: {objectLast.id}, {objectLast.description}");
    }
}