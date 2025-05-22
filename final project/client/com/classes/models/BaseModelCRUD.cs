namespace SqliteDB {
    using System.Reflection;

    partial class BaseModel<T> {
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
        
        public void UpdateRecord(T obj) {
            string sqlQuery = "UPDATE " + this._tablename + "SET ";
            PropertyInfo[] properties = typeof(T).GetProperties();
            PropertyInfo? idProperty = obj.GetType().GetProperty("id");
            if (idProperty != null) {
                foreach (var property in properties) {
                    sqlQuery += "'" + property.Name + "' = '" + property.GetValue(obj).ToString() + "'";
                }
                sqlQuery += " WHERE id = " + idProperty.GetValue(obj);
            } else {
                throw new Exception("Id property wasn't found");
            }
            db.ObjectQuery(sqlQuery);
        }

        public void DeleteRecord(T obj) {

        }
    }
}