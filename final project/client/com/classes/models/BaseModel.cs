namespace SqliteDB {
    partial class BaseModel<T> {
        protected Database db;
        protected string _tablename { get; set; }
        public int id { get; set; }

        protected BaseModel() { }

        protected BaseModel(Database db) {
            if (db.IsDatabasePresent()) {
                this.db = db;
                _tablename = this.GetType().Name.ToLower();
            } else {
                throw new Exception("Database is not present");
            }
        }
    }
}