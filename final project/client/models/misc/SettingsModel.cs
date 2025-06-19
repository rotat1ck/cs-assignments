using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqliteDB;

namespace client.models.misc {
    public class Settings : BaseModel<Settings> {
        public int id { get; set; }
        public string name { get; set; }
        public int value { get; set; }

        public Settings() : base() { }

        public Settings(Database db) : base(db) { }
    }
}
