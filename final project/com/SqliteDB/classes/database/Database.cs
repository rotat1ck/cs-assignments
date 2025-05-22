namespace SqliteDB;
    
using Microsoft.Data.Sqlite;

public partial class Database : IDatabase {
    static protected SqliteConnection? db = null!;
    static protected string? dbPath = null;
    static protected SqliteCommand? cmd = null!;

    public Database() : this("database.db") { }

    public Database(string path) {
        dbPath = path;
        if (IsDatabasePresent()) {
            db = new SqliteConnection("Data Source=" + path);
        }
    }

    ~Database() {
        db.Close();
    }
}
