namespace SqliteDB;
    
using System.Data;
using Microsoft.Data.Sqlite;

public partial class Database : IDatabase {
    public T SimpleFirstByComparison<T>(string table, string column, T value) {
        return Query<T>($"SELECT * FROM {table} WHERE {column} = {value}")[0];
    }

    public DataTable GetSqlObjectQueryResults(SqliteDataReader r) {
        DataTable entries = new();
        try {
            if (r.HasRows) {
                for (int i = 0; i < r.FieldCount; i++) {
                    entries.Columns.Add(new DataColumn(r.GetName(i)));
                }
            }

            int j = 0;
            while (r.Read()) {
                DataRow row = entries.NewRow();
                entries.Rows.Add(row);
                
                for (int i = 0; i < r.FieldCount; i++) {
                    entries.Rows[j][i] = r.GetValue(i);
                }

                    j++;
            }
        } catch (SqliteException ex) {
            throw new InvalidOperationException($"Error reading data from database: {ex.Message}", ex);
        }

        CloseConnection();
        return entries;
    }

    public DataTable ObjectQuery(string sqlQuery) {
        OpenConnection();
        cmd = db.CreateCommand();
        cmd.CommandText = sqlQuery;

        return GetSqlObjectQueryResults(cmd.ExecuteReader());
    }
}
