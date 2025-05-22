using System.Data;
using SqliteDB;

static class DbTest {
    public static void Test(Database db) {
        if (db.IsDatabasePresent()) {
            try {
                // Common Query 
                List<string> names = db.Query<string>("SELECT name FROM objects");
                List<int> numbers = db.Query<int>("SELECT number FROM objects");
                Console.WriteLine($"Query results:");
                for (int i = 0; i < names.Count; i++) {
                    Console.WriteLine($"House name: {names[i]}, house number: {numbers[i]}");
                }

                // Object Query ( •̀ ω •́ )✧
                DataTable dataTable = db.ObjectQuery("SELECT * FROM objects");
                Console.WriteLine($"ObjectQuery results:");

                Console.Write("Received columns: ");
                foreach (DataColumn column in dataTable.Columns) {
                    Console.Write(column.ColumnName + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Received objects: ");
                foreach (DataRow row in dataTable.Rows) {
                    Console.WriteLine($"House id: {row["id"]}, House name: {row["name"]}, house number: {row["number"]}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex}");
            }
        } else {
            Console.WriteLine("Database file not found!");
        }
    }
}