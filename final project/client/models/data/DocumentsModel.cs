using SqliteDB;

namespace client.models.data {
    public class Documents : BaseModel<Documents> {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }

        public Documents() : base() { }

        public Documents(Database db) : base(db) { }
    }
}
