using Microsoft.Data.Sqlite;

interface IDatabase {
    // Base DB functions
    bool IsDatabasePresent();
    bool OpenConnection();
    bool CloseConnection();
    public bool CommitChanges();

    // Basic query functions
    List<T> GetSqlQueryResults<T>(SqliteDataReader r);
    public List<T> Query<T>(string sqlQuery);

    // Use-simple query functions
    public T SimpleFirstByComparison<T>(string table, string column, T value);
    public T SimpleFirstOnJoin<T>(string table, string joinTable, string column, T value);

    // Migrations
    // Later...
}