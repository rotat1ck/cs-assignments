namespace SqliteDB;
    
using System.Reflection;
using Microsoft.Data.Sqlite;

public partial class BaseModel<T> {
    /// <summary>
    ///     Создает переданный объект в базе
    /// </summary>
    /// <param name="obj"></param>
    public void CreateRecord(T obj) {
        SqliteCommand cmd = db.GetEmptyCommand();
        string sqlQuery = "INSERT INTO " + this._tablename;
        
        PropertyInfo[] properties = typeof(T).GetProperties();
        PropertyInfo? idProperty = obj.GetType().GetProperty("id");
        string[] columnNames = new string[properties.Length];
        string[] values = new string[properties.Length];
        if (idProperty != null) {
            int AIId = ParseAutoIncrementID(obj);
            idProperty.SetValue(obj, AIId);
    
            for (int i = 0; i < properties.Length; i++) {
                columnNames[i] = properties[i].Name;
                values[i] = properties[i].GetValue(obj).ToString();
            }
            UpdateAutoIncrementID(obj, AIId + 1);
        }
        sqlQuery += " (" + string.Join(", ", columnNames) + ") VALUES (@" + string.Join(", @", columnNames) + ")";
        cmd.CommandText = sqlQuery;

        for (int i = 0; i < columnNames.Length; ++i) {
            cmd.Parameters.AddWithValue("@" + columnNames[i], values[i]);
        }
        db.DirectQuery(cmd);
    }
    
    /// <summary>
    ///     Обновляет переданный объект в базе по первому свойству
    /// </summary>
    /// <param name="obj"></param>
    public void UpdateRecord(T obj) {
        SqliteCommand cmd = db.GetEmptyCommand();
        string sqlQuery = "UPDATE " + this._tablename + " SET ";

        PropertyInfo[] properties = typeof(T).GetProperties();
        List<string> sqlParams = [];

        for (int i = 1; i < properties.Length; ++i) {
            sqlParams.Add(properties[i].Name + " = @" + properties[i].Name);
        }
        sqlQuery += string.Join(", ", sqlParams);
        sqlQuery += " WHERE " + properties[0].Name + " = @" + properties[0].Name;
        
        cmd.CommandText = sqlQuery;

        foreach (var property in properties) {
            cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj).ToString());
        }
        db.DirectQuery(cmd);
    }

    /// <summary>
    ///     Обновляет текущий объект в базе
    /// </summary>
    public void Commit() {
        SqliteCommand cmd = db.GetEmptyCommand();
        string sqlQuery = "UPDATE " + this._tablename + " SET ";
        PropertyInfo[] properties = this.GetType().GetProperties();
        List<string> sqlParams = [];
        foreach (var property in properties) {
            sqlParams.Add(property.Name + " = @" + property.Name);
        }
        sqlQuery += string.Join(", ", sqlParams);
        sqlQuery += " WHERE " + properties[0].Name + " = " + properties[0].GetValue(this).ToString();
        db.ObjectQuery(sqlQuery);
    }

    /// <summary>
    ///     Удаляет переданный объект из базы
    /// </summary>
    /// <param name="obj"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void DeleteRecord(T obj) {
        string sqlQuery = "DELETE FROM " + this._tablename + " WHERE ";
        PropertyInfo? idProperty = obj.GetType().GetProperty("id");
        if (idProperty != null) {
            sqlQuery += "id = " + idProperty.GetValue(obj).ToString();
        } else {
            throw new InvalidOperationException("Id property wasn't found");
        }
        db.ObjectQuery(sqlQuery);
    }
}