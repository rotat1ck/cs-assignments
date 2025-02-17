class Emp : Human {
    double salary;
    
    public Emp(string fName, string lName, double salary) {
        firstName = fName;
        lastName = lName;
        this.salary = salary;
    }

    public void Print() {
        Console.WriteLine($"Lastname: {lastName}\nFirstname: {firstName}\nSalary: {salary}");
    }
}