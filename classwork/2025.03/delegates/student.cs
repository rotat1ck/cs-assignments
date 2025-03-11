class Student {
    public string? FirstName { get; set;}
    public string? LastName { get; set;}
    public DateTime Date { get; set; }

    public override string ToString(){
        return $"{LastName} {FirstName} - {Date.ToShortDateString()}";
    }

}