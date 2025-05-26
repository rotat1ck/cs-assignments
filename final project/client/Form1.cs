namespace client;
using SqliteDB;

public partial class Form1 : Form {
    private Database db;
    public Form1() {
        InitializeComponent();

        this.db = InitDB("client.db");

    }

    public static Database InitDB(string dbPath) {
        return new Database(dbPath);
    }
}
