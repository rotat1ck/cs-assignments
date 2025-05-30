using SqliteDB;

namespace client.models.linking {
    public class Photos_Objects : BaseModel<Photos_Objects> {
        public int id { get; set; }
        public int photo_id { get; set; }
        public int object_id { get; set; }

        public Photos_Objects() : base() { }

        public Photos_Objects(Database db) : base(db) { }
    }
}
