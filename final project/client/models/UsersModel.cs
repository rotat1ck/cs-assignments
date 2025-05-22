using SqliteDB;

class Users : BaseModel<Users> {
    //new string _tablename = "users"; // необязательно

    public int id { get; set; }
    public int employee_id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }

    public Users(Database db) : base(db) {
        
    }
}