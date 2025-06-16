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
        public void QueryAll() {
            usersModel.Query();
        }

        [TestMethod]
        public void Filter() {
            usersModel.Filter(("username", "goida"));
        }

        [TestMethod]
        public void FilterById() {
            usersModel.Filter(2);
        }

        [TestMethod]
        public void FilterFirst() {
            usersModel.FilterFirst();
        }

        [TestMethod]
        public void CreateRecord() {
            if (usersModel.Query().Count() == 0) {
                usersModel.CreateRecord(new Users {
                    username = "username",
                    password = "password",
                    email = "email",
                    rights = 0,
                    employee_id = 0
                });
            }
        }

        [TestMethod]
        public void DeleteRecord() {
            List<Users> users = usersModel.Query();
            if (users.Count() > 0) {
                usersModel.DeleteRecord(users[0]);
            }
        }

        [TestMethod]
        public void UpdateRecord() {
            List<Users> users = usersModel.Query();
            if (users.Count() > 0) {
                users[0].username = "new username";
                users[0].password = "new password";
                users[0].email = "new email";
                usersModel.UpdateRecord(users[0]);
            }
        }
    }
}
