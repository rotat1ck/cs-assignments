namespace SqliteDB;
    
using System.Reflection;

public partial class BaseModel<T> {
    /// <summary>
    ///     Создает переданный объект в базе
    /// </summary>
    /// <param name="obj"></param>
    public void CreateRecord(T obj) {
        string sqlQuery = "INSERT INTO " + this._tablename;
        
        PropertyInfo[] properties = typeof(T).GetProperties();
        PropertyInfo? idProperty = obj.GetType().GetProperty("id");
        string[] columnNames = new string[properties.Length];
        string[] values =  new string[properties.Length];
        if (idProperty != null) {
            int AIId = ParseAutoIncrementID(obj);
            idProperty.SetValue(obj, AIId);
    
            for (int i = 0; i < properties.Length; i++) {
                columnNames[i] = properties[i].Name;
                values[i] = "'" + properties[i].GetValue(obj).ToString() + "'";
            }
            UpdateAutoIncrementID(obj, AIId + 1);
        }
        sqlQuery += " (" + string.Join(", ", columnNames) + ") VALUES (" + string.Join(", ", values) + ")";
        db.ObjectQuery(sqlQuery);
    }
    
    /// <summary>
    ///     Обновляет переданный объект в базе, 
    ///     при отсутсвии поля id у obj - InvalidOperationException
    /// </summary>
    /// <param name="obj"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void UpdateRecord(T obj) {
        string sqlQuery = "UPDATE " + this._tablename + " SET ";
        PropertyInfo[] properties = typeof(T).GetProperties();
        PropertyInfo? idProperty = obj.GetType().GetProperty("id");
        List<string> sqlParams = [];
        if (idProperty != null) {
            foreach (var property in properties) {
                sqlParams.Add(property.Name + " = '" + property.GetValue(obj).ToString() + "'");
            }
            sqlQuery += string.Join(", ", sqlParams);
            sqlQuery += " WHERE id = " + idProperty.GetValue(obj).ToString();
        } else {
            throw new InvalidOperationException("Id property wasn't found");
        }
        db.ObjectQuery(sqlQuery);
    }

    /// <summary>
    ///     Обновляет текущий объект в базе
    /// </summary>
    public void Commit() {
        string sqlQuery = "UPDATE " + this._tablename + " SET ";
        PropertyInfo[] properties = this.GetType().GetProperties();
        List<string> sqlParams = [];
        foreach (var property in properties) {
            sqlParams.Add(property.Name + " = '" + property.GetValue(this).ToString() + "'");
        }
        sqlQuery += string.Join(", ", sqlParams);
        sqlQuery += " WHERE " + properties[0].Name + " = " + properties[0].GetValue(this).ToString();
        db.ObjectQuery(sqlQuery);
    }

    /// <summary>
    ///     Удаляет переданный объект из базы, 
    ///     при отсутсвии поля id у obj - InvalidOperationException
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
        int AIId = Convert.ToInt32(idProperty.GetValue(obj));
        UpdateAutoIncrementID(obj, AIId);
    }
}