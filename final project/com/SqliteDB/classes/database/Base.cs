namespace SqliteDB;
    
using Microsoft.Data.Sqlite;

public partial class Database : IDatabase {
    public bool OpenConnection() {
        try {
            db.OpenAsync();
            return true;
        } catch (SqliteException) {
            return false;
        }
    }

    public bool IsDatabasePresent() {
        return File.Exists(dbPath);
    }

    public bool CloseConnection() {
        try {
            db.CloseAsync();
            return true;
        } catch (SqliteException) {
            return false;
        }
    }

    public bool CommitChanges() {
        try { 
            int res = cmd.ExecuteNonQuery();
            return true;
        } catch (SqliteException) {
            return false;
        }
    }
}
