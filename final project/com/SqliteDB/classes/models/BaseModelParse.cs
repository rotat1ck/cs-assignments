namespace SqliteDB;

using System.Data;
using System.Reflection;
public partial class BaseModel<T> {
    private int ParseAutoIncrementID(T obj) {
        string sqlQuery = "SELECT seq from sqlite_sequence WHERE name = ";
        PropertyInfo? property = obj.GetType().GetProperty("_tablename");

        if (property != null) {
            sqlQuery += "'" + property.GetValue(obj) + "'";
        } else {
            sqlQuery += "'" + obj.GetType().Name.ToLower() + "'";
        }

        List<int> res = db.Query<int>(sqlQuery);
        if (res.Count == 0) {
            CreateAutoIncrementField(obj);
            return 1;
        }
        return res[0];
    }
    private void UpdateAutoIncrementID(T obj, int newID) {
        string sqlQuery = "UPDATE sqlite_sequence set seq = " + newID.ToString() + " WHERE name = ";
        PropertyInfo? property = obj.GetType().GetProperty("_tablename");

        if (property != null) {
            sqlQuery += "'" + property.GetValue(obj) + "'";
        } else {
            sqlQuery += "'" + obj.GetType().Name.ToLower() + "'";
        }
        db.ObjectQuery(sqlQuery);
    }
    private void CreateAutoIncrementField(T obj) {
        string sqlQuery = "INSERT INTO sqlite_sequence(name, seq) VALUES (";
        PropertyInfo? property = obj.GetType().GetProperty("_tablename");
        
        if (property != null) {
            sqlQuery += "'" + property.GetValue(obj) + "'";
        } else {
            sqlQuery += "'" + obj.GetType().Name.ToLower() + "'";
        }
        sqlQuery += ", '1')";
        db.ObjectQuery(sqlQuery);
    }
    
    private List<T> ParseDataTable(DataTable dt) {
        List<T> res = [];
        foreach (DataRow obj in dt.Rows) {
            T? temp = (T?)Activator.CreateInstance(typeof(T), db);
            foreach (DataColumn column in dt.Columns) {
                PropertyInfo? property = temp.GetType().GetProperty(column.ColumnName);
                if (property != null) {
                    property.SetValue(temp, Convert.ChangeType(obj[column.ColumnName], property.PropertyType));
                }
            }
            res.Add(temp);
        }
        return res;
    }
}