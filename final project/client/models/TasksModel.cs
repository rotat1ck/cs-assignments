using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqliteDB;

namespace client.models {
    public class Tasks : BaseModel<Tasks> {
        public int id { get; set; }
        public string name { get; set; }
        public string content { get; set; }

        public Tasks() : base() { }

        public Tasks(Database db) : base(db) { }
    }
}
