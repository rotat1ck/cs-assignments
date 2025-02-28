class Code {
    static void Main() {
        // Auditory auditory = new();
        // foreach (var st in auditory) {
        //     Console.WriteLine(st);
        // }
        // Console.WriteLine();
        // auditory.Sort(new DataComparer());
        // foreach (var item in auditory) {
        //     Console.WriteLine(item);
        // }

        // Child child1 = new() {Name = "Vova", Age = 12};
        // Console.WriteLine($"Start values: ");
        // Child child2 = (Child)child1.Clone();

        // Console.WriteLine($"Child1: {child1}");
        // Console.WriteLine($"Child2: {child2}");

        // child2.Age = 17;
        // child2.Name = "Oleg";

        // Console.WriteLine($"Child1: {child1}");
        // Console.WriteLine($"Child2: {child2}");

        Student student1 = new Student {
            FirstName = "Ivan",
            LastName = "Ivanov",
            BirthDate = new DateTime(2003, 01, 05),
            StudentCard = new StudentCard {
                Number = 14,
                Series = "83JFK912"
            }
        };

        Student student2 = (Student)student1.Clone();
        Console.WriteLine(student1);
        Console.WriteLine(student2);

        student2.StudentCard.Number = 111111;
        student2.StudentCard.Series = "AAAAAAAA";

        Console.WriteLine(student1);
        Console.WriteLine(student2);
    }
}