using SqliteDB;

namespace client.models.linking {
    public class Objects_Types : BaseModel<Objects_Types> {
        public int id { get; set; }
        public string name { get; set; }

        public Objects_Types() : base() { }

        public Objects_Types(Database db) : base(db) { }
    }
}
