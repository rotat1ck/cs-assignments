using Microsoft.Data.Sqlite;

partial class Database : IDatabase {
    Database() {
        if (Isdata) {
            IDatabase.db = new SqliteConnection("Data Source=client.db");
        }
    }

    ~Database() {
        IDatabase.db.Close();
    }
}