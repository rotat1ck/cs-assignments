class Student {
    public delegate void ExamDelegate(string t);
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime Date { get; set; }

    // public void Exam(object sender, ExamEventArgs e) {
    //     Console.WriteLine($"Student {LastName} solved the {e.Task}");
    // }

    public void Exam(string task) {
        Console.WriteLine($"Student {LastName} solved the {task}");
    }
}

class ExamEventArgs : EventArgs {
    public string? Task { get; set; }
}