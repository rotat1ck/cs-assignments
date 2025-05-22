namespace SqliteDB;

using Microsoft.Data.Sqlite;
using System.Data;

public interface IDatabase {
    // Base DB functions
    bool IsDatabasePresent();
    bool OpenConnection();
    bool CloseConnection();
    public bool CommitChanges();

    // Basic query functions
    List<T> GetSqlQueryResults<T>(SqliteDataReader r);
    public List<T> Query<T>(string sqlQuery);

    // Use-simple query functions
    public T SimpleFirstByComparison<T>(string table, string column, T value); // <- trash
    DataTable GetSqlObjectQueryResults(SqliteDataReader r);
    public DataTable ObjectQuery(string sqlQuery);

    // Migrations
    // Later...
}
