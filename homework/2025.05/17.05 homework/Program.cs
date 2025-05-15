class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 2): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.D1: {
                    One();
                    break;
                } case ConsoleKey.D2: {
                    Two();
                    break;
                } default: {
                    invalidInput = true;
                    break;
                }
            }
        }

        // 🥨
    }

    static bool invalidInput = false;

    static ConsoleKey getKeyPress(string msg) {
        ConsoleKeyInfo keyPressed;

        while (true) {
            if (invalidInput) {
                Console.WriteLine("Invalid input!\n");
            }
            invalidInput = false;
            Console.Write(msg);
            keyPressed = Console.ReadKey();
            Console.WriteLine();

            if (keyPressed.Key == ConsoleKey.Escape) {
                Environment.Exit(0);
            } else {
                return keyPressed.Key;
            }
        }
    }

    static void One() {
        Manager manager = new();
        var product = manager.Add("Hello, world!");
        Console.WriteLine($"Product: {product}");
    }

    static void Two() {
        Context context = new() {
            Vocabulary = new() {
                {'I', "1"},
                {'V', "5"},
                {'X', "10"},
                {'L', "50"},
                {'C', "100"},
                {'D', "500"},
                {'M', "1000"}
            },
            Source = "VIM",
            Position = 0
        };

        var expression = new NonterminalExpression();
        try {
            expression.Interpreter(context);
            Console.WriteLine($"Result: {context.Translated}");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}