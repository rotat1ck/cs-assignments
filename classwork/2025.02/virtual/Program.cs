class Code {
    static void Main() {
        
        // Learner[] learners = [
        //     new SchoolChild("Vova", "Petrov", new DateTime(2014, 10, 3), "School1", "4D"),
        //     new Student("Ivan", "Ivanov", new DateTime(2007, 10, 22), "IT-TOP", "23/3")
        // ];
        

        // foreach(Learner learner in learners) {
        //     Console.WriteLine(learner.ToString());
        //     learner.Think();
        //     learner.Study();
        // }

        Learner st = new Student("Ivan", "Ivanov", new DateTime(2007, 10, 22), "IT-TOP", "23/3");

        Console.WriteLine($"Full type name: {st.GetType().FullName}");
        Console.WriteLine($"Current type name: {st.GetType().Name}");
        Console.WriteLine($"Base type name: {st.GetType().BaseType}");
        Console.WriteLine($"Is current type abstract: {st.GetType().IsAbstract}");
        Console.WriteLine($"Is base type abstract: {st.GetType().BaseType.IsAbstract}");
        Console.WriteLine($"Is current object - class: {st.GetType().IsClass}");
        Console.WriteLine($"Is reachable outside current build: {st.GetType().IsVisible}");
    }
}

// Equals - виртуальный
// Equals - статический
// Finalize - очистка ресурсов
// GetHashCode - виртуальный метод, возвращает хэш-код объекта
// GetType - возвращает тип класса
// ToString - виртуальный метод, возвращает строковое представление объекта