class Shop {
    public delegate string ShopDelegate();

    public string name { get; set;}
    public string address { get; set;}
    public string description { get; set;}
    public string phone { get; set;}
    public string email { get; set; }
    public double area { get; set; }

    public Shop(string name, string address, string description, string phone, string email, double area) {
        this.name = name;
        this.address = address;
        this.description = description;
        this.phone = phone;
        this.email = email;
        this.area = area;
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

    public string GetArea() {
        return area.ToString();
    }

    public override string ToString(){
        return $"Name {name}, Address {address}, Description {description}, Phone {phone}, Email {email}, Area {area}";
    }

    static public Shop operator +(Shop old, double area) {
        return new Shop(old.name, old.address, old.description, old.phone, old.email, old.area + area);
    }

    static public Shop operator -(Shop old, double area) {
        return new Shop(old.name, old.address, old.description, old.phone, old.email, old.area - area);
    }

    public override bool Equals(object? obj) {
        return this.ToString() == obj.ToString();
    }

    static public bool operator ==(Shop old, Shop newShop) {
        return old.Equals(newShop);
    }

    static public bool operator !=(Shop old, Shop newShop) {
        return !(old == newShop);
    }

    static public bool operator >(Shop old, Shop newShop) {
        return old.area > newShop.area;
    }

    static public bool operator <(Shop old, Shop newShop) {
        return !(old > newShop);
    }
}