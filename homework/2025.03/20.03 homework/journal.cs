class Journal {
    public delegate string JournalStringDelegate();
    public delegate DateTime JournalDateTimeDelegate();

    public string name { get; set;}
    public DateTime created { get; set;}
    public string description { get; set;}
    public string phone { get; set;}
    public string email { get; set; }

    public Journal(string name, DateTime created, string description, string phone, string email) {
        this.name = name;
        this.created = created;
        this.description = description;
        this.phone = phone;
        this.email = email;
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
}