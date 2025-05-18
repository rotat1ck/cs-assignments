using System.Data;

static class ModelsTest {
    public static void Test(Database db) {
        Objects objectsModel = new Objects(db);
        List<Objects> objects = objectsModel.Query<Objects>();
        foreach (Objects obj in objects) {
            Console.WriteLine(obj.name + obj.description + obj.location);
        }
    }
}