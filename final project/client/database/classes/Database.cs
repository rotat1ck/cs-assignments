using Microsoft.Data.Sqlite;

partial class Database : IDatabase {
    static protected SqliteConnection? db = null!;
    static protected SqliteCommand? cmd = null!;

    Database() {
        if (!IsDatabasePresent()) {
            db = new SqliteConnection("Data Source=client.db");
        }
    }

    ~Database() {
        db.Close();
    }
}