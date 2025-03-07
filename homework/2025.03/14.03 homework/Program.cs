using System.Collections;

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
        ArrayList list = new();

        Random random = new Random();
        for (int i = 0; i < 50; i++) {
            list.Add(random.Next() * 200 - 100);
        }

        int count = 0;
        foreach (int i in list) {
            if (i >= -100 && i <= 100) {
                count++;
            }
        }
        
        Console.WriteLine(count);
        Console.WriteLine();
    }

    static void Two() {
        char input = Console.ReadKey().KeyChar;
        Console.Clear();
        if (char.IsAsciiDigit(input)) {
            Console.WriteLine("Is digit");
        } else {
            Console.WriteLine("Not a digit");
        }
        Console.WriteLine();
    }

    static void Three() {
        string? input = Console.ReadLine();
        foreach (char c in input) {
            if (char.IsAsciiDigit(c)) {
                Console.Write(c + " ");
            }
        }
        Console.WriteLine();
    }

    static void Four() {
        string? input = Console.ReadLine();
        int sum = 0;

        foreach (char c in input) {
            if (char.IsDigit(c)) {
                sum += int.Parse(c.ToString());
            }
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine();
    }

    static void Five() {
        Four();
    }

    static void Six() {
        string? input = Console.ReadLine();
        int sum = 0;
        int max = 0;
        foreach (char c in input) {
            if (c == ' ') {
                sum++;
                if (sum > max) {
                    max = sum;
                }
            } else {
                sum = 0;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine();
    }

    static void Seven() {
        Console.Write("Enter word: ");
        string? input = Console.ReadLine().ToLower();
        HashSet<char> letters = new(input);
        Console.WriteLine("Number of unique letters: " + letters.Count);
        Console.WriteLine();
    }

    static void Eight() {
        Console.Write("Enter first word: ");
        string? input1 = Console.ReadLine().ToLower();
        Console.Write("Enter second word: ");
        string? input2 = Console.ReadLine().ToLower();

        List<char> letters1 = new(input1);
        HashSet<char> letters2 = new(input2);
        foreach (char ch in letters1) {
            if (letters2.Contains(ch)) {
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }
        }
        Console.WriteLine();
    }

    static void Nine() {
        Console.Write("Enter first word: ");
        string? input1 = Console.ReadLine().ToLower();
        Console.Write("Enter second word: ");
        string? input2 = Console.ReadLine().ToLower();
        Console.Write("Enter third word: ");
        string? input3 = Console.ReadLine().ToLower();
        string? input = input1 + input2 + input3;
        Hashtable letters = [];

        foreach (char ch in input) {
            if (letters.ContainsKey(ch)) {
                letters[ch] = (int?)letters[ch] + 1;
            } else {
                letters[ch] = 1;
            }
        }

        foreach (var item in letters.Keys) {
            if ((int?)letters[item] == 1) {
                Console.WriteLine($"Non repeated letter: {item}");
            }
        }
        Console.WriteLine();
    }

    static void Ten() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        ArrayList words = new(10);

        foreach (string word in input) {
            words.Add(word);
            Console.Write(word + " ");
        }
        Console.WriteLine("\n");
    }
}