using System.Data;
using System.Reflection;

partial class BaseModel<T> {
    public void CreateRecord(T obj) {
        string sqlQuery = "INSERT INTO " + this._tablename;
        PropertyInfo[] properties = typeof(T).GetProperties();
        
        string[] columnNames = new string[properties.Length];
        string[] values = new string[properties.Length];

        for (int i = 0; i < properties.Length; i++) {
            columnNames[i] = properties[i].Name;
            values[i] = "'" + properties[i].GetValue(obj).ToString() + "'";
        }
        sqlQuery += " (" + string.Join(", ", columnNames) + ") VALUES (" + string.Join(", ", values) + ")";
        db.ObjectQuery(sqlQuery);
    }
    
    public void UpdateRecord(T obj) {

    }

    public void DeleteRecord(T obj) {

    }
}