using SqliteDB;

namespace client.models {
    public class Roles : BaseModel<Roles> {
        public int id { get; set; }
        public string name { get; set; }

        public Roles() : base() { }

        public Roles(Database db) : base(db) { }
    }
}
