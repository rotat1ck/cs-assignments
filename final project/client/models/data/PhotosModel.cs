using SqliteDB;

namespace client.models.data {
    public class Photos : BaseModel<Photos> {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }

        public Photos() : base() {  }

        public Photos(Database db) : base(db) { }
    }
}
