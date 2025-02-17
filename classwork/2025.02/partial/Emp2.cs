class Emp2 : Human2 {
    double salary;
    public Emp2(string firstName, string lastName) : base(firstName, lastName) {}

    public Emp2(string firstName, string lastName, double salary) 
        : base(firstName, lastName) {
            this.salary = salary;
        }

    public void Print() {
        base.show();
        Console.WriteLine($"Salary: {salary}");
    }
}