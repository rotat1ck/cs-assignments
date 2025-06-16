using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqliteDB;

namespace unit_tests.SqliteDB {
    public class Users : BaseModel<Users> {
        //public new string _tablename = "users";

        public int id { get; set; }
        public int employee_id { get; set; }
        public int rights { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public Users() : base() { }

        public Users(Database db) : base(db) {

        }
    }

    [TestClass]
    public class ModelTests {
        public static Database db = new Database("client.db");
        public static Users usersModel = new Users(db);

        [TestMethod]
        public void Init() {
            
            
        }

        [TestMethod]
        public void QueryAll() {
            usersModel.Query();
        }

        [TestMethod]
        public void Filter() {
            usersModel.Filter(("username", "goida"));
        }
    }
}
