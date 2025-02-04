class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 6): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.D1: {
                    One();
                    break;
                } case ConsoleKey.D2: {
                    Two();
                    break;
                } case ConsoleKey.D3: {
                    Three();
                    break;
                } case ConsoleKey.D4: {
                    Four();
                    break;
                } case ConsoleKey.D5: {
                    Five();
                    break;
                } case ConsoleKey.D6: {
                    Six();
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
        double a, b, c;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("True statements: ");

        if (a < b && b < c) {
            Console.WriteLine($"{a} < {b} < {c}");
        } else if (b > a && a > c) {
            Console.WriteLine($"{b} > {a} > {c}");
        }
        Console.WriteLine();
    }

    static void Two() {
        double a, b, c, d;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        if (a < 0 || b < 0) {
            return;
        }
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter D: ");
        d = Convert.ToDouble(Console.ReadLine());

        if (a % b == c || a % b == d) {
            Console.WriteLine($"{a} % {b} == {c} || {d}");
        } else {
            Console.WriteLine($"{a} % {b} != {c} || {d}");
        }
        Console.WriteLine();
    }

    static void Three() {
        double a, b, c, d;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter D: ");
        d = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Max: {Math.Max(Math.Max(a, b), Math.Max(c, d))}");
        Console.WriteLine($"Min: {Math.Min(Math.Min(a, b), Math.Min(c, d))}");
    }

    static void Four() {
        double a, b;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        
        a = a < 0 ? -a : a;
        b = b < 0 ? -b : b;

        double halfSum = (a + b) / 2;
        double sqrt = Math.Sqrt(a * b);

        Console.WriteLine($"Halfsum: {halfSum}");
        Console.WriteLine($"Square root of halfsum: {sqrt}");
        Console.WriteLine();
    }

    static void Five() {
        double a, b, c;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == b && b == c) {
            Console.WriteLine("Height is same");
        } else {
            Console.WriteLine("Height isn't same");
        }
        Console.WriteLine();
    }

    static void Six() {
        double weight;
        Console.Write("Enter weight: ");
        weight = Convert.ToDouble(Console.ReadLine());

        if (weight < 60) {
            Console.WriteLine("First group");
        } else if (weight < 64 ) {
            Console.WriteLine("Second group");
        } else if (weight < 69) {
            Console.WriteLine("Third group");
        } else {
            Console.WriteLine("No group");
        }
        Console.WriteLine();
    }
}