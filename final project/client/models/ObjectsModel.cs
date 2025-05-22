using SqliteDB;

class Objects : BaseModel<Objects> {
    //new string _tablename = "objects"; // необязательно

    public int id { get; set; }
    public int object_type { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string location { get; set; }
    public int number { get; set; }

    public Objects() : base() { }

    public Objects(Database db) : base(db) {
        
    }
}