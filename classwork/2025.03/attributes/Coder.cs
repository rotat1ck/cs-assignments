[Coder]
class Emp {
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Salary { get; set; }

    [Coder("John", "2017-3-29")]
    public void IncreaseWages(double wage) {
        Salary += wage;
    }
}