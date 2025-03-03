using System.Diagnostics.CodeAnalysis;

class Code {
    static void Main() {

        // ANONYMOUS TYPES

        // User user = new() {Name = "Vova", lastName = "Ivanov"};
        // var pers = new {Name = "Ivan", Age = 200};
        // Console.WriteLine(pers.GetType());

        // string name = "Petr";
        // int age = 2000;

        // var pers2 = new {name, age};
        // Console.WriteLine(pers2.name);

        // var users = new[] {
        //     new {Name = "Anna"},
        //     new {Name = "Olga"}
        // };

        // foreach (var i in users) {
        //     Console.WriteLine(i.Name);
        // }

        // TUPLES

        // var test = (10, 20);
        // Console.WriteLine(test.Item1);
        // Console.WriteLine(test.Item2);
        // test.Item1 *= 20;
        // Console.WriteLine(test.Item1);

        // var test2 = (count: 200, sum: 20000);
        // Console.WriteLine(test2.count);
        // Console.WriteLine(test2.sum);

        // (int, int, int) GetValues() {
        //     var res = (1, 6, 100);
        //     return res;
        // }

        // var test = GetValues();
        // Console.WriteLine(test.Item1);

        // RECORD

        // var pers3 = new Pers("Ivan");
        // pers3.Name = "Test";

        User user = new() {Name = "test", lastName = "test"};
        User user2 = new() {Name = "test", lastName = "test"};
        Console.WriteLine(user.Equals(user2)); // ссылочный тип

        Pers pers1 = new Pers("test");
        Pers pers2 = new Pers("test");
        Console.WriteLine(pers1.Equals(pers2)); // по значению

        var pers3 = pers1 with { Name = "tool" };
    }

    public record Pers {
        public string Name { get; init; }

        public Pers(string name) {
            Name = name;
        }
    }
}