class Code {
    static void Main() {
        Five();
    }

    static void One() {
        int x1_min, y1_min, x1_max, y1_max;
        int x2_min, y2_min, x2_max, y2_max;
        Console.Write("1. Enter down-left coords (x, y): ");
        x1_min = Convert.ToInt32(Console.ReadLine());
        y1_min = Convert.ToInt32(Console.ReadLine());
        Console.Write("1. Enter top-right coords (x, y): ");
        x1_max = Convert.ToInt32(Console.ReadLine());
        y1_max = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. Enter down-left coords (x, y): ");
        x2_min = Convert.ToInt32(Console.ReadLine());
        y2_min = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. Enter top-right coords (x, y): ");
        x2_max = Convert.ToInt32(Console.ReadLine());
        y2_max = Convert.ToInt32(Console.ReadLine());  


        int x_min = Math.Min(x1_min, x2_min);
        int y_min = Math.Min(y1_min, y2_min);
        int x_max = Math.Max(x1_max, x2_max);
        int y_max = Math.Max(y1_max, y2_max);

        Console.WriteLine($"Min: ({x_min}, {y_min})");
        Console.WriteLine($"Max: ({x_max}, {y_max})");
        Console.WriteLine();
    }

    static void Two() {
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

    static void Three() {
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

    static void Four() {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n / 100 > n % 10) {
            Console.WriteLine($"1. First number is larger");
        } else {
            Console.WriteLine($"1. Last number is larger");
        }

        if (n / 100 > n / 10 % 10) {
            Console.WriteLine($"2. First number is larger");
        } else {
            Console.WriteLine($"2. Second number is larger");
        }

        if (n / 10 % 10 > n % 10) {
            Console.WriteLine($"3. Second number is larger");
        } else {
            Console.WriteLine($"3. Last number is larger");
        }
        Console.WriteLine();
    }

    static void Five() {
        double a, b, c, x, y;
        Console.Write("Enter a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c: ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y: ");
        y = Convert.ToDouble(Console.ReadLine());

        if ((a <= x && b <= y) || (a <= x && c <= y) || 
            (b <= x && a <= y) || (b <= x && c <= y) || 
            (c <= x && a <= y) || (c <= x && b <= y)) {
            Console.WriteLine("Brick will fit");
        } else {
            Console.WriteLine("Brick wont fit");
        }
        Console.WriteLine();
    }
}