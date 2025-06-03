using SqliteDB;

namespace client.models.data {
    public class Positions : BaseModel<Positions> {
        public int id { get; set; }
        public string name { get; set; }

        public Positions() : base() { }

        public Positions(Database db) : base (db) { }
    }
}
