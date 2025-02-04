class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            int press = getKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ", [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
            Console.Clear();
            switch (press) {
                case 0: {
                    Zero();
                    break;
                } case 1: {
                    One();
                    break;
                } case 2: {
                    Two();
                    break;
                } case 3: {
                    Three();
                    break;
                } case 4: {
                    Four();
                    break;
                } case 5: {
                    Five();
                    break;
                } case 6: {
                    Six();
                    break;
                } case 7: {
                    Seven();
                    break;
                } case 8: {
                    Eight();
                    break;
                } case 9: {
                    Nine();
                    break;
                }
            }
        }

        // 🥨
    }

    static int getKeyPress(string msg, int[] validKeys) {
        ConsoleKeyInfo keyPressed;

        while (true) {
            Console.Write(msg);
            keyPressed = Console.ReadKey();
            Console.WriteLine();

            if (keyPressed.Key == ConsoleKey.Escape) {
                Environment.Exit(0);
            } else if (int.TryParse(keyPressed.KeyChar.ToString(), out int input)) {
                if (Array.Exists(validKeys, num => num.Equals(input))) {
                    return int.Parse(keyPressed.KeyChar.ToString());
                }
            }
            
            Console.Clear();
            Console.WriteLine("Invalid input\n");
        }
        
    }

    static void Zero() {
        double x, a;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        
        double[] res = [-1, -1];
        res[0] = 7 * Math.Pow(x, 2) + (3 * x) + 6;
        res[1] = 12 * Math.Pow(a, 2) + (7 * a) + 12;
        Console.WriteLine($"Results: a) {res[0]} b) {res[1]}");
    }

    static void One() {
        double a, b;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Result: x = {-b / a}");
    }

    static void Two() {
        double a, b;
        Console.Write("Enter first side: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Perimeter: {a + b + Math.Sqrt(a * a + b * b)}");
    }

    static void Three() {
        double a, b, h;
        Console.Write("Enter first side: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        h = Convert.ToDouble(Console.ReadLine());

        double side = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));
        Console.WriteLine($"Perimeter: {a + b + 2 * side}");
    }

    static void Four() {
        double x1, y1;
        double x2, y2;
        double x3, y3;

        Console.Write("Enter first coordinates (x y): ");
        string[] input = Console.ReadLine().Split(" ");
        x1 = Convert.ToDouble(input[0]);
        y1 = Convert.ToDouble(input[1]);
        Console.Write("Enter second coordinates (x y): ");
        string[] input1 = Console.ReadLine().Split(" ");
        x2 = Convert.ToDouble(input1[0]);
        y2 = Convert.ToDouble(input1[1]);
        Console.Write("Enter third coordinates (x y): ");
        string[] input2 = Console.ReadLine().Split(" ");
        x3 = Convert.ToDouble(input2[0]);
        y3 = Convert.ToDouble(input2[1]);

        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        double c = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

        double p = (a + b + c) / 2;
        Console.WriteLine($"Perimeter: {a + b + c}");
        Console.WriteLine($"Area: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
    }

    static void Five() {
        // 🤨
        for (int x = 100; x < 1000; ++x) {
            int last = x % 10;
            int result = x / 10;
            int newNumber = last * 100 + result;

            if (newNumber == 237) {
                Console.WriteLine($"x: {x}");
                break;
            }
        }
    }

    static void Six() {
        bool a = true;
        bool b = false;
        bool c = false;
        Console.WriteLine($"a || b = {a || b}");
        Console.WriteLine($"a && b = {a && b}");
        Console.WriteLine($"b || c = {b || c}");
    }

    static void Seven() {
        bool a = true;
        bool b = false;
        bool c = false;
        Console.WriteLine($"!a && b = {!a && b}");
        Console.WriteLine($"a || !b = {a || !b}");
        Console.WriteLine($"a && b || c = {a && b || c }");
    }

    static void Eight() {
        bool a = true;
        bool b = false;
        bool c = false;
        Console.WriteLine($"a || b && !c = {a || b && !c}");
        Console.WriteLine($"!a && !b = {!a && !b}");
        Console.WriteLine($"!(a && c) || b = {!(a && c) || b}");
        Console.WriteLine($"a && !b || c = {a && !b || c}");
        Console.WriteLine($"a && (!b || c) = {a && (!b || c)}");
        Console.WriteLine($"a || (!(b && c)) = {a || (!(b && c))}");
    }

    static void Nine() {
        double x, y;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("True conditions: ");
        
        if (x < 2 && y < 3) {
            Console.WriteLine($"{x} < 2 && {y} < 3");
        } if (!(x < 2)) {
            Console.WriteLine($"!({x} < 2)");
        } if (x < 1 || y < 2) {
            Console.WriteLine($"{x} < 1 || {y} < 2");
        } if (!(x < 0 && x < 5)) {
            Console.WriteLine($"!({x} < 0 && {x} < 5)");
        } if (x < 0 && y > 5) {
            Console.WriteLine($"{x} < 0 && {y} > 5");
        } if (10 < x && x < 20) {
            Console.WriteLine($"10 < {x} < 20");
        } if (x > 3 || x < 1) {
            Console.WriteLine($"{x} > 3 || {x} < 1");
        } if (0 < y && y < 4 && x < 5) {
            Console.WriteLine($"0 < {y} < 4 && {x} < 5");
        } if (x > 3 && x < 10) {
            Console.WriteLine($"{x} > 3 && {x} < 10");
        }
    }
}