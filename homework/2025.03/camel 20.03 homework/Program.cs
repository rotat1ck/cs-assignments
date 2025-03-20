using System.Linq;
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

    delegate int Func(int a, int b);
    static void One() {
        int Sum(int a, int b) {
            return a + b;
        }
        Console.Write("Enter two numbers: ");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] nums = (from s in input select int.Parse(s)).ToArray();

        Func func = Sum;
        Console.WriteLine($"Result: {func(nums[0], nums[1])}");
    }

    delegate bool Filter(int n);
    static void Two() {
        int[] Func(int[] nums, Filter filter) {
            return (from n in nums where filter(n) select n).ToArray();
        }
        Console.Write("Enter size: ");
        int.TryParse(Console.ReadLine(), out int size);
        Console.Write("Enter numbers: ");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] nums = (from s in input select int.Parse(s)).ToArray();
        Array.Sort(nums);

        Filter filter = n => n > 10;
        int[] result = Func(nums, filter);
        Console.WriteLine($"Result: {string.Join(" ", result)}");
    }

    static void Three() {
        Button.clicked += delegate {
            Console.WriteLine("Button clicked!");
        };
        Button.Click();
    }

    delegate double MathOp(double a, double b);
    static void Four() {
        Console.Write("Enter an expression: ");
        string? expression = Console.ReadLine();
        char sign = ' ';

        foreach (char item in expression) {
            if (item == '+' || item == '-' || item == '*' || item == '/') {
                sign = item;
                break;
            }
        }

        try {
            string[] num = expression.Split(sign, StringSplitOptions.RemoveEmptyEntries);
            MathOp? del = null;

            switch (sign) {
                case '+': {
                    del = (a, b) => a + b;
                    break;
                } case '-': {
                    del = (a, b) => a - b;
                    break;
                } case '*': {
                    del = (a, b) => a * b;
                    break;
                } case '/': {
                    del = (a, b) => {
                        if (b == 0) {
                            throw new DivideByZeroException("Cannot divide by zero");
                        }
                        return a / b;
                    };
                    break;
                } default: {
                    throw new InvalidOperationException();
                }
            }
            Console.WriteLine($"Result: {del(double.Parse(num[0]), double.Parse(num[1]))}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    delegate string Transform(string s);
    delegate Transform Combine(Transform func1, Transform func2);
    static void Five() {
        Transform func1 = s => new string(s.Reverse().ToArray());
        Transform func2 = s => s.ToUpper();
        Combine combine = (func1, func2) => s => func1(func2(s));

        Console.WriteLine(combine(func1, func2)("meow 12345"));
    }

    delegate string ProcessData(string s);
    static void Six() {
        string toupper(string s) => s.ToUpper();
        string removeSpaces(string s) => s.Replace(" ", "");
        string reverse(string s) => new string(s.Reverse().ToArray());
        ProcessData[] actions = [
            toupper,
            removeSpaces,
            reverse
        ];

        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        string? result = actions.Aggregate(input, (current, action) => action(current));
        Console.WriteLine($"Result: {result}");
    }
}