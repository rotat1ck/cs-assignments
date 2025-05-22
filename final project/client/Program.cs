using SqliteDB;

class Code {
    static void Main() {
        Database db = new("client.db");
        ModelsTest.Test(db);
    }
}