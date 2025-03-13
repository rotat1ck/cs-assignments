class Code {
    static void Main() {
        List<Student> group = [
            new Student {
                FirstName = "Ivan",
                LastName = "Ivanov",
                date = new DateTime(2004, 02, 03)
            }, new Student {
                FirstName = "Anna",
                LastName = "Ivanova",
                date = new DateTime(2003, 02, 03)
            }
        ];


        Teacher teacher = new();
        foreach (Student student in group) {
            teacher.examEvent += student.Exam;
        }
        ExamEventArgs eventArgs = new() { Task = "Task"};
        teacher.Exam(eventArgs);

        // teacher.Exam("Test");
        // teacher.examEvent.Invoke("Overall reting 2!");
    }
}