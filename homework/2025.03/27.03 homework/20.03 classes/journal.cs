class Journal {
    public delegate string JournalStringDelegate();
    public delegate DateTime JournalDateTimeDelegate();

    public string name { get; set;}
    public DateTime created { get; set;}
    public string description { get; set;}
    public string phone { get; set;}
    public string email { get; set; }
    public int employees { get; set;}

    public Journal(string name, DateTime created, string description, string phone, string email, int employees) {
        this.name = name;
        this.created = created;
        this.description = description;
        this.phone = phone;
        this.email = email;
        this.employees = employees;
    }

    public string GetName() {
        return name;
    }

    public DateTime GetCreatedDate() {
        return created;
    }

    public string GetDescription() {
        return description;
    }

    public string GetPhone() {
        return phone;
    }

    public string GetEmail() {
        return email;
    }

    public string GetEmployees() {
        return employees.ToString();
    }

    public override string ToString() {
        return $"Name {name}, Created {created.ToShortDateString()}, Description {description}, Phone {phone}, Email {email}, Employees {employees}";
    }

    static public Journal operator +(Journal old, int employees) {
        return new Journal(old.name, old.created, old.description, old.phone, old.email, old.employees + employees);
    }

    static public Journal operator -(Journal old, int employees) {
        return new Journal(old.name, old.created, old.description, old.phone, old.email, old.employees - employees);
    }

    public override bool Equals(object? obj) {
        return this.ToString() == obj.ToString();
    }

    static public bool operator ==(Journal old, Journal newJournal) {
        return old.Equals(newJournal);
    }

    static public bool operator !=(Journal old, Journal newJournal) {
        return !(old == newJournal);
    }

    static public bool operator >(Journal old, Journal newJournal) {
        return old.employees > newJournal.employees;
    }

    static public bool operator <(Journal old, Journal newJournal) {
        return !(old > newJournal);
    }
}