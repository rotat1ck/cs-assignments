namespace SqliteDB;

using System.Data;

public partial class BaseModel<T> {
    public T Filter(int id) {
        string sqlQuery = "SELECT * FROM " + _tablename + " WHERE id = " + id;
        DataTable dt = db.ObjectQuery(sqlQuery);
        return ParseDataTable(dt)[0];
    }
    public List<T> Filter(params (string key, object value)[] filters) {
        string sqlQuery = "SELECT * FROM " + _tablename;
        List<T> res = [];

        if (filters.Length > 0) {
            sqlQuery += " WHERE ";
        } 
        
        for (int i = 0; i < filters.Length; i++) {
            sqlQuery += filters[i].key + " = '" + filters[i].value + "'";
            if (filters.Length - i > 1) {
                sqlQuery += " AND ";
            }
        }

        DataTable dt = db.ObjectQuery(sqlQuery);
        return ParseDataTable(dt);
    }

    public T FilterFirst(params (string key, object value)[] filters) {
        return Filter(filters)[0];
    }

    public T FilterLast(params (string key, object value)[] filters) {
        return Filter(filters)[^1];
    }
}
