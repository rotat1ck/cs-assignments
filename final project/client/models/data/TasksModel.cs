using SqliteDB;

namespace client.models.data {
    public class Tasks : BaseModel<Tasks> {
        public int id { get; set; }
        public string name { get; set; }
        public string content { get; set; }

        public Tasks() : base() { }

        public Tasks(Database db) : base(db) { }
    }
}
