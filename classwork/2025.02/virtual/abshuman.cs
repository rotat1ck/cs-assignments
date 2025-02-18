abstract class AbsHuman {
    string firstName = null!;
    string lastName = null!;
    DateTime birthDate;

    public AbsHuman(string firstName, string lastName, DateTime birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }
    
    public abstract void Think();

    public virtual void Print() {
        Console.WriteLine($"\nLastname: {lastName}\nFirstname : {firstName}\nBirthdate: {birthDate.ToLongDateString()}");
    }

    public override string ToString() {
        return $"\nLastname: {lastName}\nFirstname : {firstName}\nBirthdate: {birthDate.ToLongDateString()}\n";
    }
}