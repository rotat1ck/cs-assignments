class Shop {
    public delegate string ShopDelegate();

    public string name { get; set;}
    public string address { get; set;}
    public string description { get; set;}
    public string phone { get; set;}
    public string email { get; set; }

    public Shop(string name, string address, string description, string phone, string email) {
        this.name = name;
        this.address = address;
        this.description = description;
        this.phone = phone;
        this.email = email;
    }

    public string GetName() {
        return name;
    }

    public string GetAddress() {
        return address;
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