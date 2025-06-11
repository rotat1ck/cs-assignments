namespace SqliteDB;

using System.Data;
using Microsoft.Data.Sqlite;

public partial class BaseModel<T> {
    /// <summary>
    ///     ������ �� id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>��������� ������� ���� T</returns>
    public T Filter(int id) {
        SqliteCommand cmd = db.GetEmptyCommand();
        string sqlQuery = "SELECT * FROM " + _tablename + " WHERE id = @id";

        cmd.CommandText = sqlQuery;
        cmd.Parameters.AddWithValue("@id", id);

        DataTable dt = db.DirectQuery(cmd);
        return ParseDataTable(dt)[0];
    }
    public List<T> Filter(params (string key, object value)[] filters) {
        SqliteCommand cmd = db.GetEmptyCommand();
        string sqlQuery = "SELECT * FROM " + _tablename;
        List<string> sqlParams = [];

        if (filters.Length > 0) {
            sqlQuery += " WHERE ";
        } 
        
        for (int i = 0; i < filters.Length; i++) {
            sqlParams.Add("@" + filters[i].key + " = @value" + i);
        }
        sqlQuery += string.Join(" AND ", sqlParams);

        cmd.CommandText = sqlQuery;

        for (int i = 0; i < filters.Length; i++) {
            cmd.Parameters.AddWithValue($"@value{i}", filters[i].value);
        }

        DataTable dt = db.DirectQuery(cmd);
        return ParseDataTable(dt);
    }

    public T FilterFirst(params (string key, object value)[] filters) {
        return Filter(filters)[0];
    }

    public T FilterLast(params (string key, object value)[] filters) {
        return Filter(filters)[^1];
    }
}
