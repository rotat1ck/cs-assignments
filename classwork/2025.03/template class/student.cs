class Student : IComparable<Student> {
    public string? FirstNmae { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString() {
        return $"{LastName} - {FirstNmae} - {BirthDate.ToLongDateString()}";
    }

    public int CompareTo(Student other) {
        return this.LastName.CompareTo(other.LastName);
    }
}