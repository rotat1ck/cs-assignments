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
                // } case ConsoleKey.D3: {
                //     Four();
                //     break;
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
                // } default: {
                //     invalidInput = true;
                //     break;
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
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();
        string[] res = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Word count: {0}", res.Length);
        Console.WriteLine();
    }

    static void Two() {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();
        string[] res = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string output = "";
        for (int i = 0; i < res.Length; ++i) {
            output += new string(res[i].Reverse().ToArray()) + " ";
        }
        Console.WriteLine("Result: {0}", output.Trim());
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();
        char[] toFind = ['a', 'e', 'i', 'o', 'u'];
        int res = 0;

        foreach (var ch in toFind) {
            int i = 0;
            while ((i = input.IndexOf(ch, i)) != -1) {
                res++;
                i++;
            }
        }

        Console.WriteLine("Result: {0}", res);
        Console.WriteLine();
    }
}

