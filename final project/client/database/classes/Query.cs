using Microsoft.Data.Sqlite;

partial class Database : IDatabase {
    public Type GetSqlQueryReturnType<T>() {
        return temp.GetType();
    }

    public T Query<T>(string sqlQuery) {
        cmd = db.CreateCommand();
        cmd.CommandText = sqlQuery;

        if (cmd.ExecuteNonQuery() == -1) {
            using (SqliteDataReader r = cmd.ExecuteReader()) {
                while (r.Read()) {
                    switch(sqlQuery) {
                        case "string": {
                            
                            break;
                        }
                    }
                }
            }
        }
    }
}