using System.Data;
using System.Reflection;

class BaseModel {
    protected Database db;
    protected string _tablename { get; set; }
    protected int id { get; set; }

    protected BaseModel(Database db) {
        this.db = db;
        _tablename = this.GetType().Name.ToLower();
    }

    public List<T> Query<T>() {
        DataTable dt = db.ObjectQuery("SELECT * FROM " + _tablename);
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