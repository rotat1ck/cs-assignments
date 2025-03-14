class Code {
    static void Main() {
        // List<Student> group = [
        //     new Student {
        //         FirstName = "Ivan",
        //         LastName = "Ivanov",
        //         date = new DateTime(2004, 02, 03)
        //     }, new Student {
        //         FirstName = "Anna",
        //         LastName = "Ivanova",
        //         date = new DateTime(2003, 02, 03)
        //     }
        // ];


        // Teacher teacher = new();
        // foreach (Student student in group) {
        //     teacher.examEvent += student.Exam;
        // }
        // ExamEventArgs eventArgs = new() { Task = "Task"};
        // teacher.Exam(eventArgs);

        // teacher.Exam("Test");
        // teacher.examEvent.Invoke("Overall reting 2!");

        // - - 

        // Подписка на событие +=
        // Отписка от события -=

        Teacher teacher = new();
        // Student student = new();
        // teacher.examEvent += student.Exam;
        // teacher.examEvent -= student.Exam;

        // List<Student> group = [
        //     new Student {
        //         FirstName = "Ivan",
        //         LastName = "Ivanov",
        //         Date = new DateTime(2004, 02, 03)
        //     }, new Student {
        //         FirstName = "Anna",
        //         LastName = "Ivanova",
        //         Date = new DateTime(2003, 02, 03)
        //     }, new Student {
        //         FirstName = "Vova",
        //         LastName = "Potapov",
        //         Date = new DateTime(2002, 06, 09)
        //     }
        // ];

        // foreach (Student student in group) {
        //     teacher.examEvent += student.Exam;
        // }

        // Student student1 = new() {
        //     FirstName = "Petr",
        //     LastName = "Petrov",
        //     Date = new DateTime(2001, 02, 03)
        // };

        // teacher.examEvent += student1.Exam;
        // teacher.Exam("Task #1");
        // Console.WriteLine();
        // teacher.examEvent -= student1.Exam;
        // teacher.Exam("Task #2");

        Console.WriteLine("The use of events");
        Simple simple = new();

        simple.eventDouble += delegate(double a, double b) {
            if (b != 0) {
                return a / b;
            }
            throw new DivideByZeroException();
        };

        double n1 = 5.7, n2 = 3.2;
        Console.WriteLine(simple.OnEventDouble(n1, n2));

        Console.WriteLine("Using a local variable");
        int num = 5;

        simple.eventVoid += delegate(int n) { 
            Console.WriteLine($"{num} + {n} = {num + n}");
        };
        simple.eventVoid += n => {
            Console.WriteLine($"{num} + {n} = {num + n}");
        };

        simple.OnEventVoid();
        simple.OnEventVoid(6);
        
        Simple.AnonyomousDelegateVoid voidDel = delegate {
            Console.WriteLine("Anonymous void delegate");
        };
        voidDel += () => {
            Console.WriteLine("Anonymous void lambda");
        };
        voidDel();

        // => lambda expression
        // delegate(params) => {}
        // (params) => {}
    }
}