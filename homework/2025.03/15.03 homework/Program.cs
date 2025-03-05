using System.Collections;

class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 5): ");
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
        int.TryParse(Console.ReadLine(), out int num1);
        int.TryParse(Console.ReadLine(), out int num2);

        int res = 1;
        for (int i = num1; i <= num2; ++i) {
            res *= i;
        }
        Console.WriteLine(res);
        Console.WriteLine();
    }

    static void Two() {
        City goidacity = new("GoidaCity", 100000, "123");
        List<string> districts = ["Center", "Park", "South goida", "North goida"];
        goidacity.Districts = districts;
        Console.WriteLine(goidacity);
        Console.WriteLine();
    }

    static void Three() {
        Employee employee = new("Ivan Ivanov", new DateTime(2000, 1, 1), "71234567890",
        "ivan@gmail.com", "Manager", "Lead of the sells department");
        employee.Email = "Ivanov@mail.ru";
        Console.WriteLine(employee);
        Console.WriteLine();
    }

    static void Four() {
        string[] input = Console.ReadLine().Split(" ");

        int min = 9999;
        foreach (var word in input) {
            min = Math.Min(min, word.Length);
        }

        Console.WriteLine($"Min lenght: {min}");
        Console.WriteLine();
    }

    static void Five() {
        string[] input = Console.ReadLine().Split(" ");
        Hashtable hashtable = new();

        foreach (var word in input) {
            if (hashtable.ContainsKey(word)) {
                hashtable[word] = (int)hashtable[word] + 1;
            } else {
                hashtable[word] = 1;
            }
        }

        foreach (var item in hashtable.Keys) {
            if ((int)hashtable[item] == 1) {
                Console.WriteLine(item);
            }
        }
        Console.WriteLine();
    }
}