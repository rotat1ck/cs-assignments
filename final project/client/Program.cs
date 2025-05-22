using SqliteDB;

class Code {
    static void Main() {
        Database db = new();
        ModelsTest.Test(db);
    }
}