class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 8): ");
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
                } case ConsoleKey.D7: {
                    Seven();
                    break;
                } case ConsoleKey.D8: {
                    Eight();
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
        Archive.JournalFunc();
    }

    static void Two() {
        Archive.ShopFunc();
    }
    
    static void Three() {
        Console.Write("Enter books: ");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Books books = new(input);
        books += "Goida book";
        Console.WriteLine(books);
        foreach (string book in books) {
            Console.WriteLine(book);
        }
    }

    static void Four() {
        Console.Write("Enter an expression: ");

        string? expression = Console.ReadLine().Replace(" ", "");
        double result = 0;
        char sign = '+';

        for (int i = 0; i < expression.Length; ++i) {
            if (char.IsDigit(expression[i])) {
                int.TryParse(expression[i].ToString(), out int num);
                
                Calc.CalcDelegate? del = null;
                switch (sign) {
                    case '+': {
                        del = Calc.Add;
                        break;
                    } case '-': {
                        del = Calc.Sub;
                        break;
                    } case '*': {
                        del = Calc.Mul;
                        break;
                    } case '/': {
                        del = Calc.Div;
                        break;
                    }
                }
                result = del(result, num);
            } else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/') {
                sign = expression[i];
            }
        }

        Console.WriteLine($"Result: {result}\n");
    }

    static void Five() {
        try {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Num: {num}");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();

    }

    static void Six() {
        Console.Write("Enter symbol: ");
        char symbol = Console.ReadLine().First();
        Console.Write("Enter lenght: ");
        int.TryParse(Console.ReadLine(), out int len);

        for (int i = 0; i < len; i++, Console.WriteLine()) {
            for (int j = 0; j < len; j++) {
                Console.Write(symbol + " ");
            }
        }
        Console.WriteLine();
        
    }

    static void Seven() {
        Console.Write("Enter number: ");
        string? num = Console.ReadLine();

        if (num == new string(num.Reverse().ToArray())) {
            Console.WriteLine("true");
        } else {
            Console.WriteLine("false");
        }
    }

    static void Eight() {
        Console.WriteLine("1. 10 -> 2");
        Console.WriteLine("2. 10 -> 8");
        Console.WriteLine("3. 10 -> 16");
        Console.WriteLine("4. 2 -> 10");
        Console.WriteLine("5. 8 -> 10");
        Console.WriteLine("6. 16 -> 10");
        Console.Write("Choose option: ");
        int.TryParse(Console.ReadLine(), out int choice);

        Console.Write("Enter number: ");
        string? input = Console.ReadLine();
        object result;
        try {
            int number = Convert.ToInt32(input);
            switch (choice) {
                case 1: {
                    result = Convert.ToString(number, 2);
                    break;
                } case 2: {
                    result = Convert.ToString(number, 8);
                    break;
                } case 3: {
                    result = Convert.ToString(number, 16);
                    break;
                } case 4: {
                    result = Convert.ToInt32(input, 2);
                    break;
                } case 5: {
                    result = Convert.ToInt32(input, 8);
                    break;
                } case 6: {
                    result = Convert.ToInt32(input, 16);
                    break;
                } default: {
                    throw new Exception("Invalid option!");
                }
            }
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            return;
        }
        Console.WriteLine($"Result: {result}\n");
    }
}