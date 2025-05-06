class Code {
    static void Main() {
        Calculator calc = new();
        int result = 0;

        result = calc.Add(5);
        Console.WriteLine(result);

        result = calc.Sub(3);
        Console.WriteLine(result);

        result = calc.Undo(2);
        Console.WriteLine(result);

        result = calc.Redo(1);
        Console.WriteLine(result);
    }
}