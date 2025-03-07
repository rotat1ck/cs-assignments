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
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(input.Length);
        Console.WriteLine();
    }

    static void Two() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string result = "";
        foreach (var word in input) {
            result += new string(word.Reverse().ToArray()) + " ";
        }
        Console.WriteLine(result.Trim());
        Console.WriteLine();
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
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

    static void Four() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        Console.Write("Enter substring to find: ");
        string? toFind = Console.ReadLine();
        int res = 0;
        int i = 0;
        while ((i = input.IndexOf(toFind, i)) != -1) {
            res++;
            i++;
        }
        
        Console.WriteLine("Result: {0}", res);
        Console.WriteLine();
    }

    static void Five() {
        Console.Write("Enter sentence: ");
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


    static void Six() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        int sum = 1;
        int max = 1;
        for (int i = 1; i < input.Length; ++i) {
            if (input[i] == input[i - 1]) {
                sum++;
                if (sum > max) {
                    max = sum;
                }
            } else {
                sum = 1;
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
        Console.Write("Enter word: ");
        string? input = Console.ReadLine().ToLower();
        Hashtable letters = [];

        foreach (char ch in input) {
            if (letters.ContainsKey(ch)) {
                letters[ch] = (int?)letters[ch] + 1;
            } else {
                letters[ch] = 1;
            }
        }

        foreach (var item in letters.Keys) {
            if ((int?)letters[item] == 2) {
                Console.WriteLine($"Two same letters: {item}");
            }
        }
        Console.WriteLine();
    }
}
