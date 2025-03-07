using System.Collections;

class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ");
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
        Console.Write("Enter word: ");
        string? word = Console.ReadLine();
        string? res = "";

        for (int i = 0; i < word.Length; i += 2) {
            res += word[i];
        }

        Console.WriteLine($"Result: {res}");
        Console.WriteLine();
    }

    static void Two() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        
        Hashtable letters = [];

        foreach (char ch in input) {
            if (letters.ContainsKey(ch)) {
                letters[ch] = (int?)letters[ch] + 1;
            } else {
                letters[ch] = 1;
            }
        }

        Console.WriteLine($"Result: {letters['+']}+, {letters['*']}*");
        Console.WriteLine();
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < input.Length; i++) {
            if (input[i] == ',') {
                index = i;
                break;
            }   
        }

        if (index != -1) {
            Console.WriteLine($"Result: {input[index ..]}");
        } else {
            Console.WriteLine("Result: No comma found");
        }
        Console.WriteLine();
    }

    static void Four() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Hashtable hashtable = [];

        foreach (char ch in input[0]) {
            if (hashtable.ContainsKey(ch)) {
                hashtable[ch] = (int?)hashtable[ch] + 1;
            } else {
                hashtable[ch] = 1;
            }
        }

        Console.WriteLine($"Result: {hashtable['o']}");
        Console.WriteLine();
    }

    static void Five() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();

        int count = 0;
        foreach (char ch in input) {
            if (ch == '.' || ch == '!' || ch == '?') {
                count++;
            }
        }

        Console.WriteLine($"Result: {count}");
        Console.WriteLine();
    }


    static void Six() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine().Replace("е", "и");
        Console.WriteLine($"Result: {input}");
        Console.WriteLine();
    }

    static void Seven() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine().Replace("ах", "ух");
        Console.WriteLine($"Result: {input}");
        Console.WriteLine();
    }

    static void Eight() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        if (input.Length > 12) {
            input = input[0 .. 12];
        }

        input = input[.. 2] + new string(input[2 .. 9].Reverse().ToArray()) + input[9 ..];
        Console.WriteLine($"Result: {input}");
        Console.WriteLine();
    }
}
