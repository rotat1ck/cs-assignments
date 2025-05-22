namespace SqliteDB;
    
using Microsoft.Data.Sqlite;

public partial class Database : IDatabase {
    protected Dictionary<Type, Func<SqliteDataReader, object>> typeGetters = new() {
        { typeof(int), r => r.GetInt32(0) },
        { typeof(string), r => r.GetString(0) },
        { typeof(bool), r => r.GetBoolean(0) },
        // Add more type mappings as needed
    };

    public List<T> GetSqlQueryResults<T>(SqliteDataReader r) {
        List<T> values = new();
        
        if (typeGetters.TryGetValue(typeof(T), out var getter)) {
            while (r.Read()) {
                try {
                    var value = getter(r);
                    if (value.GetType() != typeof(T)){
                        throw new InvalidOperationException($"Expected type: {typeof(T).Name} but got type: {getter.GetType().Name}");
                    }

                    values.Add((T)getter(r));
                } catch (SqliteException ex){
                    throw new InvalidOperationException($"Error reading data from database: {ex.Message}", ex);
                }
            }
        } else {
            throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
        }
        CloseConnection();
        return values;
    }

    public List<T> Query<T>(string sqlQuery) {
        OpenConnection();
        cmd = db.CreateCommand();
        cmd.CommandText = sqlQuery;

        if (cmd.ExecuteNonQuery() == -1) {
            return GetSqlQueryResults<T>(cmd.ExecuteReader());
        } else {
            return new List<T>();
        }
    }
}
