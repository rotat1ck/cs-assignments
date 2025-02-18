class SchoolChild : Learner {
    string className;
    public SchoolChild(string firstName, string lastName, DateTime birthDate
    , string institution, string className) 
        : base(firstName, lastName, birthDate, institution) {
        this.className = className;
    }

    public override void Think() {
        Console.WriteLine($"Thinking about my school");
    }

    public override void Study() {
        Console.WriteLine($"Studying at {className}");
    }

    public override void Print() {
        base.Print();
        Console.WriteLine($"Class: {className}");
    }

    public override string ToString(){
        return base.ToString() + $"Class: {className} ";
    }
}