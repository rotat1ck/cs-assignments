class Code {
    static void Main() {
        Database db = new();
        if (db.IsDatabasePresent()) {
            try {
                List<string> names = db.Query<string>("SELECT name FROM objects");
                List<int> numbers = db.Query<int>("SELECT number FROM objects");
                Console.WriteLine($"Query results:");
                for (int i = 0; i < names.Count; i++) {
                    Console.WriteLine($"House name: {names[i]}, house number: {numbers[i]}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex}");
            }
        } else {
            Console.WriteLine("Database file not found!");
        }
    }
}