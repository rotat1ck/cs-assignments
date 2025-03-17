class Employee {
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
    public string? Description { get; set; }

    public Employee() {}

    public Employee(string name, DateTime birthDate, string phone, string email, string role, string description) {
        Name = name;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
        Role = role;
        Description = description;
    }

    public string? GetName() => Name;
    public DateTime GetBirthDate() => BirthDate; 
    public string? GetPhone() => Phone;
    public string? GetEmail() =>Email;
    public string? GetRole() => Role;
    public string? GetDescription() => Description;

    public override string ToString() {
        return $"Name {Name}, Birthdate {BirthDate.ToShortDateString()}, Phone {Phone}, Email {Email}, Role {Role}, Description {Description}";
    }
}