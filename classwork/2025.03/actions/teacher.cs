class Teacher {
    // public event Student.ExamDelegate examEvent;
    //EventHandler<T> 
    public EventHandler<ExamEventArgs> examEvent;

    public void Exam(ExamEventArgs task) {
        if (examEvent != null) {
            examEvent(this, task);
        }
    }

    // public void Exam(string task) {
    //     if (examEvent != null) {
    //         examEvent(task);
    //     }
    // }
} 