class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.D0: {
                    One();
                    break;
                } case ConsoleKey.D1: {
                    Two();
                    break;
                } case ConsoleKey.D2: {
                    Three();
                    break;
                } case ConsoleKey.D3: {
                    Four();
                    break;
                } case ConsoleKey.D4: {
                    Five();
                    break;
                } case ConsoleKey.D5: {
                    Six();
                    break;
                } case ConsoleKey.D6: {
                    Seven();
                    break;
                } case ConsoleKey.D7: {
                    Eight();
                    break;
                } case ConsoleKey.D8: {
                    Nine();
                    break;
                } case ConsoleKey.D9: {
                    Ten();
                    break;
                } default: {
                    invalidInput = true;
                    break;
                }
            }
        }

        // 🥨
    }
    static bool invalidInput = false; // 😃😃😃

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
        Console.WriteLine();
    }

    static void Two() {
        double x, y, z;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Z: ");
        z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("True conditions: ");

        if (x % 2 != 0 && y % 2 != 0) {
            Console.WriteLine($"Both {x} and {y} are odd");
        } if ((x < 20 && y >= 20) || (x >= 20 && y < 20)) {
            Console.WriteLine($"Only {x} or {y} less than 20");
        } if (x == 0 || y == 0) {
            Console.WriteLine($"{x} or {y} is equal to 0");
        } if (x < 0 && y < 0 && z < 0) {
            Console.WriteLine($"{x}, {y}, {z} are all negative");
        } if ((x % 5 == 0 && y % 5 != 0 && z % 5 != 0) ||
            (x % 5 != 0 && y % 5 == 0 && z % 5 != 0) ||
            (x % 5 != 0 && y % 5 != 0 && z % 5 == 0)) {
            Console.WriteLine($"Only {x} or {y} or {z} is divisible by 5");
        } if (x > 100 || y > 100 || z > 100) {
            Console.WriteLine($"Either one of {x}, {y}, {z} is bigger than 100");
        }
        Console.WriteLine();
    }

    static void Three() {
        double x, y;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());

        if (x > 0) {
            y = Math.Sin(x);
        } else {
            y = Math.Cos(x);
        }
        Console.WriteLine($"y = {y}");
        Console.WriteLine();
    }

    static void Four() {
        int a, b;
        Console.Write("Enter A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (b % a == 0) {
            Console.WriteLine($"{a} is a factor of {b}");
        } else {
            Console.WriteLine($"{a} is not a factor of {b}");
        }
        Console.WriteLine();
    }

    static void Five() {
        int n;
        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("True conditions: ");

        if (n % 2 == 0) {
            Console.WriteLine($"{n} is even");
        } else if (n % 10 == 7) {
            Console.WriteLine($"{n} ends with 7");
        }
        Console.WriteLine();
    }

    static void Six() {
        int kms, feet;
        Console.Write("Enter KMS: ");
        kms = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter FEET: ");
        feet = Convert.ToInt32(Console.ReadLine());

        if (kms * 1000 < feet * 0.305) {
            Console.WriteLine($"{kms} kms is less than {feet} feet");
        } else {
            Console.WriteLine($"{feet} feet is less than {kms} kms");
        }
    }

    static void Seven() {
        double a, b, c;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());

        double D = b * b - 4 * a * c;

        if (D >= 0) {
            Console.WriteLine("There is a solution");
        } else {
            Console.WriteLine("No solution");
        }
        Console.WriteLine();
    }
    
    static void Eight() {
        double circle, square;
        Console.Write("Enter circle area: ");
        circle = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter square area: ");
        square = Convert.ToDouble(Console.ReadLine());

        double r = Math.Sqrt(circle / Math.PI);
        double side = Math.Sqrt(square);

        if (2 * r <= side) {
            Console.WriteLine("Circle will fit in square");
        } if (2 * r >= side) {
            Console.WriteLine("Square will fit in circle");
        } 
        Console.WriteLine();
    }

    static void Nine() {
        double n;
        Console.Write("Enter N: ");
        n = Convert.ToDouble(Console.ReadLine());

        if (-5 <= n && n <= 3) {
            Console.WriteLine($"{n} is within -5 to 3");
        } else {
            Console.WriteLine($"{n} is not within -5 to 3");
        }
        Console.WriteLine();
    }

    static void Ten() {
        double a, b, c;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == b && b == c) {
            Console.WriteLine("All triangle sides are equal");
        } else {
            Console.WriteLine("Triangle sides are not equal");
        }
        Console.WriteLine();
    }
}