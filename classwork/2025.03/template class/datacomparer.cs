class DataComparer : IComparer<Student> {
    public int Compare(Student x, Student y) {
        return DateTime.Compare(x.BirthDate, y.BirthDate);
    } 
}