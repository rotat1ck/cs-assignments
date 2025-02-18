class Code {
    static void Main() {
        Student student = new("Ivan", "Ivanov", "Group 1", 17);
        student.SetGrade(Subjects.Programming, 5);
        student.SetGrade(Subjects.Programming, 5);
        student.SetGrade(Subjects.Administration, 4);
        student.SetGrade(Subjects.Administration, 3);

        foreach(int i in student.getGrades(Subjects.Programming)) {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        foreach(int i in student.getGrades(Subjects.Administration)) {
            Console.Write(i + " ");
        }
    }
}