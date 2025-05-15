using Microsoft.Data.Sqlite;

partial class Database : IDatabase {
    public bool OpenConnection() {
        try {
            db.Open();
            return true;
        } catch (SqliteException) {
            return false;
        }
    }

    public bool IsDatabasePresent() {
        return File.Exists("client.db");
    }

    public bool CloseConnection() {
        try {
            db.Close();
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