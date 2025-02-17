class ChildEmp {
    protected string firstName;
    protected string lastName;
    DateTime birthDate;

    public ChildEmp(string firstName, string lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public virtual void Show() {
        Console.WriteLine($"Lastname: {lastName}\nFirstname : {firstName}\nBirthdate: {birthDate.ToShortDateString()}");
    }
}

class Employee : ChildEmp {
    double salary;
    
    public Employee(string firstName, string lastName, double salary) 
        : base(firstName, lastName) {
            this.salary = salary;
        }
    public override void Show() {
        base.Show();
        Console.WriteLine($"Salary: {salary}");
    }
}