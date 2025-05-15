interface IDatabase {
    // Base DB functions
    bool IsDatabasePresent();
    bool OpenConnection();
    bool CloseConnection();
    public bool CommitChanges();

    // Basic query functions
    // Type GetSqlQueryReturnType<T>(); // реализовать switch для автоподставления типа, использовать во всех функциях запросов
    public T Query<T>(string sqlQuery);

    // Use-simple query functions
    public T SimpleFirstByComparison<T>(string table, string column, T value);
    public T SimpleFirstOnJoin<T>(string table, string joinTable, string column, T value);

    // Migrations
    // Later...
}