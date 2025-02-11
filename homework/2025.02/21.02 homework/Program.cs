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
                // } case ConsoleKey.D4: {
                //     Five();
                //     break;
                // } case ConsoleKey.D5: {
                //     Six();
                //     break;
                // } case ConsoleKey.D6: {
                //     Seven();
                //     break;
                // } case ConsoleKey.D7: {
                //     Eight();
                //     break;
                // } case ConsoleKey.D8: {
                //     Nine();
                //     break;
                // } case ConsoleKey.D9: {
                //     Ten();
                //     break;
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
        int count = 0;
        int sum = 0;
        while (nCopy > 0) {
            sum += nCopy % 10;
            nCopy /= 10;
            count++;
        }

        int[] nums = new int[count];
        count = 0;
        while (n > 0) {
            nums[count] = n % 10;
            n /= 10;
            count++;
        }

        if (sum >= 10) {
            Console.WriteLine("Sum of every number is greater than 10");
        }

        int prod = 1;
        foreach(int i in nums) {
            prod *= i;
        } 
        if (prod >= 50) {
            Console.WriteLine("Prod of every number is greater than 50");
        }
    }
}