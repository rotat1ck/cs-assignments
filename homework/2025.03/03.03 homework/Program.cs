class Code {
    static void Main() {
        Figure circle = new Circle(5);
        Console.WriteLine(circle.Area());
        Figure square = new Square(4);
        Console.WriteLine(square.Perimeter());

        Pl cpp = new() { name = "C++", runtype = "Compiled", type = "Staticly typed", created = new DateTime(1979, 1, 1), creater = "Bjarne Stroustrup" };
        Console.WriteLine(cpp.ToString());
    }
}