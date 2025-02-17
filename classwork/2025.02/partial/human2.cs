class Human2 {
    string firstName;
    string lastName;
    DateTime birthDate;

    public Human2(string firstName, string lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Human2(string firstName, string lastName, DateTime birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public void show() {
        Console.WriteLine($"Lastname: {lastName}\nFirstname : {firstName}\nBirthdate: {birthDate.ToShortDateString()}");
    }
}