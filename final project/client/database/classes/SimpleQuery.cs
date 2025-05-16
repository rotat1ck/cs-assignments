partial class Database : IDatabase {
    public T SimpleFirstByComparison<T>(string table, string column, T value) {
        return Query<T>($"SELECT * FROM {table} WHERE {column} = @value")[0];
    }

    public T SimpleFirstOnJoin<T>(string table, string joinTable, string column, T value) {
        return Query<T>($"SELECT * FROM {table}")[0];
    }
}