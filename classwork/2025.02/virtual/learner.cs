abstract class Learner : AbsHuman {
    protected string institution;

    public Learner(string firstName, string lastName, DateTime birthDate, string institution) 
        : base(firstName, lastName, birthDate) {
        this.institution = institution;
    }

    public abstract void Study();

    public override void Print() {
        base.Print();
        Console.WriteLine($"Institution: {institution}");
    }

    public override string ToString() {
        return base.ToString() + $"Institution: {institution}\n";
    }
}