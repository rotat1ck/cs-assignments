class Users : BaseModel {
    //new string _tablename = "users"; // необязательно

    new public int id { get; set; }
    public int employee_id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }

    public Users(Database db) : base(db) {
        
    }
}