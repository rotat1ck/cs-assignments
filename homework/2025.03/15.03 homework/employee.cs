class Employee {
    string? fullName = null; 
    DateTime birthDate;
    string? phoneNumber = null;
    string? email = null;
    string? role = null;
    string? description = null;

    public Employee(string fullName, DateTime birthDate, string phoneNumber,
    string email, string role, string description) {
        this.fullName = fullName;
        this.birthDate = birthDate;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.role = role;
        this.description = description;
    }

    public string FullName {
        get { 
            return fullName;
        } set {
            fullName = value;
        }
    }

    public DateTime BirthDate {
        get {
            return birthDate;
        } set {
            birthDate = value;
        }
    }

    public string PhoneNumber {
        get {
            return phoneNumber;
        } set {
            phoneNumber = value;
        }
    }

    public string Email {
        get {
            return email;
        } set {
            email = value;
        }
    }

    public string Role {
        get {
            return role;
        } set {
            role = value;
        }
    }

    public string Description {
        get {
            return description;
        } set {
            description = value;
        }
    }

    public override string ToString(){
        return $"Name {fullName}, Birthdate {birthDate.ToShortDateString()}, Phone {phoneNumber}, Email {email}, Role {role}, Description {description}";
    }
}