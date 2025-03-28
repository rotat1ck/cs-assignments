[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
class CoderAttribute : Attribute {
    string _name = "Vova";
    DateTime _date = DateTime.Now;

    public CoderAttribute() { }

    public CoderAttribute(string name, string date) {
        try {
            _name = name;
            _date = Convert.ToDateTime(date);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    public override string ToString() => $"Coder: {_name}, Date: {_date}";
}