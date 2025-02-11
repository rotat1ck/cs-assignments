class User {
    string name;
    string lastName = "None";
    // public string userName;
    // public string userLastName;

    public User() : this("Test") { }

    public User(string name) {this.name = name;}
    
    public User(string name, string lastName) {
        this.name = name;
        this.lastName = lastName;
    }

    public void Print() {
        Console.WriteLine($"{name} - {lastName}");
    }

    public void Deconstruct(out string userName, out string userLastName) {
        userName = name;
        userLastName = lastName;
    }

    public string Name {
        get {return name;}
        set {
            if (value.Length > 2 && value.Length < 7) {
                name = value;
            } else {
                Console.WriteLine("...");
            }
        }
    }

    public string Name2 { get {return name; } }
    public string Name3 { set {name = value; } }

    public string Name4 { get; set; }
}
