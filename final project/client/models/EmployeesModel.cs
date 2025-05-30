using SqliteDB;

namespace client.models {
    public class Employees : BaseModel<Employees> {
        public int id { get; set; }
        public int role_id { get; set; }
        public int position_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public Employees() { }

        public Employees(Database db) : base(db) { }
    }
}
