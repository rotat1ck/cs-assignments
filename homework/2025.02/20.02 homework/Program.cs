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
        int x, y;
        Console.Write("Enter A: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0) {
            Console.WriteLine($"Number is 2");
        } if (x < 0 && y > 0) {
            Console.WriteLine($"Number is 1");
        } if (x > 0 && y < 0) {
            Console.WriteLine($"Number is 3");
        } else {
            Console.WriteLine($"Number is 4");
        }
        Console.WriteLine();
    }

    static void Two() {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[6];
        int count = 0;
        while (n > 0) {
            nums[count] = n % 10;
            n /= 10;
            count++;
        }

        if (nums[0] + nums[1] + nums[2] == nums[3] + nums[4] + nums[5]) {
            Console.WriteLine("Number is lucky");
        } else {
            Console.WriteLine("Number isn't lucky");
        }
        Console.WriteLine();
    }

    static void Three() {
        Console.Write("Choose day of the year (1-365): ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose weekday number for 1 of january (1-7): ");
        int d = Convert.ToInt32(Console.ReadLine());

        int dayOfWeek = (k + d - 1) % 7;

        switch (dayOfWeek) {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        Console.WriteLine();
    }

    static void Four() {
        Console.Write("Choose month number (1-12): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose day number (1-31): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 ];
        
        if (n == 1) {
            m--;
            n = daysInMonth[m - 1];
        } else {
            n--;
        }
        Console.WriteLine($"Last day: {n}.{m}");

        if (n == daysInMonth[m - 1]) {
            m++;
            n = 1;
        } else {
            n++;
        } 
        Console.WriteLine($"Next day: {n}.{m}");
        Console.WriteLine();
    }

    static void Five() {
        double a, b, c;
        string[] input = Console.ReadLine().Split();
        a = Convert.ToDouble(input[0]);
        b = Convert.ToDouble(input[1]);
        c = Convert.ToDouble(input[2]);

        if (a + b > c && a + c > b && b + c > a) {
            Console.WriteLine("Valid triangle");
        } else {
            Console.WriteLine("Invalid triangle");
        }
        Console.WriteLine();
    }

    static void Six() {
        string[] input = Console.ReadLine().Split();
        double[] sides = new double[3];
        sides[0] = Convert.ToDouble(input[0]);
        sides[1] = Convert.ToDouble(input[1]);
        sides[2] = Convert.ToDouble(input[2]);
        Array.Sort(sides);

        if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2)) {
            Console.WriteLine("Valid");
        } else {
            Console.WriteLine("Invalid");
        }
        Console.WriteLine();
    }

    static void Seven() {
        int n;
        Console.Write("Enter price: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("┌────────┬───────┐");
        Console.WriteLine("│ Weight │ Price │");
        Console.WriteLine("├────────┼───────┤");
        for (int i = 50; i <= 1000; i += 50) {
            double price = (double)i / 1000 * n;
            Console.WriteLine($"│ {i, 5}g │ {price, 5} │");
        }
        Console.WriteLine("└────────┴───────┘");
        Console.WriteLine();
    }

    static void Eight() {
        Console.WriteLine("┌────────┐");
        Console.WriteLine("│ Number │");
        Console.WriteLine("├────────┤");
        for (double i = 2.1; i < 2.9; i += 0.1) {
            Console.WriteLine($"│ {Math.Round(i, 1), 6} │");
        }
        Console.WriteLine("└────────┘");
        Console.WriteLine();
    }

    static void Nine() {
        int a, b;
        Console.Write("Enter A: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 500) {
            Console.WriteLine("A is greater than 500");
            Console.WriteLine();
            return;
        }

        Console.Write("Enter B: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (b < -10) {
            Console.WriteLine("B is less than -10");
            Console.WriteLine();
            return;
        } else if (b < a) {
            Console.WriteLine("B is less than A");
            Console.WriteLine();
            return;
        }
        
        int sum = 0;
        for (int i = 100; i <= 500; ++i) {
            sum += i;
        }
        Console.WriteLine($"A. {sum}");

        int sum2 = 0;
        for (int i = a; i <= 500; ++i) {
            sum2 += i;
        }
        Console.WriteLine($"B. {sum2}");

        int sum3 = 0;
        for (int i = -10; i <= b; ++i) {
            sum3 += i;
        }
        Console.WriteLine($"C. {sum3}");

        int sum4 = 0;
        for (int i = a; i <= b; ++i) {
            sum4 += i;
        }
        Console.WriteLine($"D. {sum4}");
        Console.WriteLine();    
    }

    static void Ten() {
        int a, b;
        Console.Write("Enter A: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (!(1 <= a && a <= 20)) {
            Console.WriteLine("A is less than 1 or greater than 20");
            Console.WriteLine();
            return;
        }

        Console.Write("Enter B: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (!(1 <= a && a <= 20)) {
            Console.WriteLine("B is less than 1 or greater than 20");
            Console.WriteLine();
            return;
        } else if (b < a) {
            Console.WriteLine("B is less than A");
            Console.WriteLine();
            return;
        }

        int prod = 1;
        for (int i = 8; i <= 15; ++i) {
            prod *= i;
        }
        Console.WriteLine($"A. {prod}");

        int prod1 = 1;
        for (int i = a; i <= 20; ++i) {
            prod1 *= i;
        }
        Console.WriteLine($"B. {prod1}");

        int prod2 = 1;
        for (int i = a; i <= b; ++i) {
            prod2 *= i;
        }
        Console.WriteLine($"C. {prod2}");

        int prod3 = 1;
        for (int i = a; i <= b; ++i) {
            prod3 *= i;
        }
        Console.WriteLine($"D. {prod3}");
        Console.WriteLine();
    }
}