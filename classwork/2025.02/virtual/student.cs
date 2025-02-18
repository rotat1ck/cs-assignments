class Student : Learner {
    string groupName;
    public Student(string firstName, string lastName, DateTime birthDate
    ,string institution, string groupName) 
        : base(firstName, lastName, birthDate, institution) {
        this.groupName = groupName;
    }


    public override void Think() {
        Console.WriteLine("Thinking about my university");
    }

    public override void Study(){
        Console.WriteLine($"Studying!!!");
    }

    public override void Print() {
        base.Print();
        Console.WriteLine($"Group: {groupName}");
    }

    public override string ToString() {
        return base.ToString() + $"Group: {groupName} ";
    }
}