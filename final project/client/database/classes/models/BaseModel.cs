partial class BaseModel<T> {
    protected Database db;
    protected string _tablename { get; set; }
    protected int id { get; set; }

    protected BaseModel(Database db) {
        this.db = db;
        _tablename = this.GetType().Name.ToLower();
    }
}