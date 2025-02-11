using System.Security.Cryptography.X509Certificates;

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

    static void Two() {
        double n;
        Console.Write("Enter N: ");
        n = Convert.ToDouble(Console.ReadLine());

        double sum = 1 - 1 / (double)2;
        for (double i = 3; i <= n; i++) {
            sum += 1.0 / i;
            Console.WriteLine(sum);
        }
    
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine();
    }

    static void Three() {
        int a, b;
        Console.Write("Enter A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToInt32(Console.ReadLine());
        int a2 = a;

        Console.WriteLine("┌────────┐");
        Console.WriteLine("│ Number │");
        Console.WriteLine("├────────┤");
        while (a > b) {
            Console.WriteLine($"│ {Math.Round(Math.Sqrt(a), 3), 6} │");
            a--;
        }
        Console.WriteLine("└────────┘");


        Console.CursorTop = 2;
        Console.CursorLeft = 13;
        Console.WriteLine("┌────────┐");
        Console.CursorLeft = 13;
        Console.WriteLine("│ Number │");
        Console.CursorLeft = 13;
        Console.WriteLine("├────────┤");
        do {
            Console.CursorLeft = 13;
            Console.WriteLine($"│ {Math.Round(Math.Sqrt(a2), 3), 6} │");
            a2--;
        } while (a2 > b);
        Console.CursorLeft = 13;
        Console.WriteLine("└────────┘");
        Console.WriteLine();
    }

    static void Four() {
        int n;
        Console.Write("Enter N: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("True statements: ");

        int nCopy = n;
        int lenght = 0;
        int sum = 0;
        while (nCopy > 0) {
            sum += nCopy % 10;
            nCopy /= 10;
            lenght++;
        }

        int[] nums = new int[lenght];
        lenght = 0;
        while (n > 0) {
            nums[lenght] = n % 10;
            n /= 10;
            lenght++;
        }

        if (sum >= 10) {
            Console.WriteLine("1. Sum of every number is greater than 10");
        }

        int prod = 1;
        foreach(int i in nums) {
            prod *= i;
        } 
        if (prod >= 50) {
            Console.WriteLine("2. Prod of every number is greater than 50");
        }

        if (lenght % 2 == 0 || lenght % 10 % 2 == 0) {
            Console.WriteLine("3. One of the numbers of length is even");
            if (lenght == 4) {
                Console.WriteLine("4. Number has 4 digits");
            }
        }

        if (nums[lenght - 1] <= 6) {
            Console.WriteLine("5. First number is less than or equal to 6");
        }

        if (nums[lenght - 1] == nums[0]) {
            Console.WriteLine("6. First and last number are equal");
        } else if (nums[lenght - 1] > nums[0]) {
            Console.WriteLine("7. Last number is greater than first number");
        } else {
            Console.WriteLine("8. Last number is less than first number");
        } 
        Console.WriteLine();
    }

    static void Five() {
        int n;
        Console.Write("Enter N: ");
        n = Convert.ToInt32(Console.ReadLine());

        int fact = 1;
        for (int i = 2; i <= n; ++i) {
            fact *= i;
        }

        Console.WriteLine($"Factorial: {fact}");
        Console.WriteLine();
    }

    static void Six() {
        int j, a, k, b, x, y, m, n;
        Console.Write("Enter number: ");
        j = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter (a, k, b, x, y, m, n): ");
        string[] input = Console.ReadLine().Split();
        a = Convert.ToInt32(input[0]);
        k = Convert.ToInt32(input[1]);
        b = Convert.ToInt32(input[2]);
        x = Convert.ToInt32(input[3]);
        y = Convert.ToInt32(input[4]);
        m = Convert.ToInt32(input[5]);
        n = Convert.ToInt32(input[6]);
        Console.WriteLine("True statements: ");

        int jCopy = j;
        int lenght = 0;
        while (jCopy > 0) {
            jCopy /= 10;
            lenght++;
        }

        int[] nums = new int[lenght];
        int sum = 0;
        lenght = 0;
        jCopy = j;
        while (jCopy > 0) {
            nums[lenght] = jCopy % 10;
            sum += jCopy % 10;
            jCopy /= 10;
            lenght++;
        }

        if (sum > k && lenght % 2 == 0) {
            Console.WriteLine($"1. Sum of digits is greater than {k} and length is even");
        }

        if (lenght % 2 == 0 && j < b) {
            Console.WriteLine($"2. Length is even and number is less than {b}");
        }

        if (nums[lenght - 1] == x && nums[0] == y) {
            Console.WriteLine($"3. First digit is {x} and last digit is {y}");
        }

        int prod = 1;
        foreach(int i in nums) {
            prod *= i;
        }
        if (prod < a && j % b == 0) {
            Console.WriteLine($"4. Product is less than {a} and number is divisible by {b}");
        }

        if (sum > m && j % n == 0) {
            Console.WriteLine($"5. Sum of digits is greater than {m} and number is divisible by {n}");
        }
        Console.WriteLine();
    }

    static void Seven() {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] nums = new double[n];
        Console.Write($"Enter elements: ");
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++) {
            nums[i] = Convert.ToDouble(input[i]);
        }

        int count = 0;
        double num = nums[0];
        while (num < 0) {
            count++;
            num = nums[count];
        }
        Console.WriteLine($"Amount of negative numbers: {count}");
        Console.WriteLine();
    }

    static void Eight() {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int res = 0;
        for (int i = 1; i <= n; i++) {
            res += 2 * i - 1;
        }

        Console.WriteLine($"Result: {res}");
        Console.WriteLine();
    }

    static void Nine() {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter elements: ");
        double[] nums = new double[n];
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++) {
            nums[i] = Convert.ToDouble(input[i]);
        }

        int count = 0;
        for(int i = 0; i < n - 1; i++) {
            if (nums[i] * nums[i + 1] < 0) {
                count++;
            }
        }

        Console.WriteLine($"Number of changes: {count}");
        Console.WriteLine();
    }

    static void Ten() {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("┌──────┐");
        Console.WriteLine("│ Less │");
        Console.WriteLine("├──────┤");
        for (int i = 1; i < n; i++) {
            if (i * i <= n) {
                Console.WriteLine($"│ {i, 4} │");
            } else {
                Console.WriteLine("├──────┤");
                Console.WriteLine("│ More │");
                Console.WriteLine("├──────┤");
                Console.WriteLine($"│ {i, 4} │");
                Console.WriteLine("└──────┘");
                break;
            }
        }
        Console.WriteLine();
    }
}