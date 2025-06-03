using SqliteDB;

namespace client.models.linking {
    public class Tasks_Objects : BaseModel<Tasks_Objects> {
        public int id { get; set; }
        public int task_id { get; set; }
        public int object_id { get; set; }

        public Tasks_Objects() : base() { }

        public Tasks_Objects(Database db) : base(db) { }
    }
}
