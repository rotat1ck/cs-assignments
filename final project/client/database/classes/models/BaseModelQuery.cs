using System.Data;

partial class BaseModel<T> {
    public List<T> Query() {
        DataTable dt = db.ObjectQuery("SELECT * FROM " + _tablename);
        return ParseDataTable(dt);
    }
}