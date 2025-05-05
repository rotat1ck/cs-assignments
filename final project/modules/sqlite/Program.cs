using Microsoft.Data.Sqlite;

class Code {
    static void Main() {
        using (var db = new SqliteConnection("Data Source=test.db")) {
            db.Open();

            var command = db.CreateCommand();
            command.CommandText = "SELECT * FROM objects";

            using (var r = command.ExecuteReader()) {
                while (r.Read()) {
                    var name = r.GetString(2);
                    var desc = r.GetString(3);

                    Console.WriteLine($"Name: {name}, Description: {desc}");
                }
            }
        }
    }
}