class StudentCard {
    public int Number {get; set;}
    public string Series {get; set;}

    public override string ToString()
    {
        return $"Студенческий билет: {Series}-{Number}";
    }
}