using SqliteDB;
using client;
using Microsoft.Data.Sqlite;
using System.Data;

namespace unit_tests.SqliteDB {
    [TestClass]
    public sealed class DBTests {
        [TestMethod]
        public void DBInitTest() {
            Database db = new Database("client.db");

        }

        [TestMethod]
        public void DBDirectQueryTest() {
            Database db = new Database("client.db");
            SqliteCommand cmd = db.GetEmptyCommand();

            cmd.CommandText = "SELECT * FROM users";
            db.DirectQuery(cmd);
        }

        // OUTDATED
        [TestMethod]
        public void DBObjectQuery() {
            Database db = new Database("client.db");
            DataTable dt = db.ObjectQuery("SELECT username FROM users");
        }   
    }
}
