using SqliteDB;

namespace client.models.linking {
    public class Documents_Objects : BaseModel<Documents_Objects> {
        public int id { get; set; }
        public int document_id { get; set; }
        public int object_id { get; set; }

        public Documents_Objects() : base() { }

        public Documents_Objects(Database db) : base(db) { }
    }
}
