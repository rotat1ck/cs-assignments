namespace SqliteDB;

using System.Data;

public partial class BaseModel<T> {
    public List<T> Query() {
        DataTable dt = db.ObjectQuery("SELECT * FROM " + _tablename);
        return ParseDataTable(dt);
    }
}
