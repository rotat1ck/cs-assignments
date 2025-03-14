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
        List<int> nums = [9, 32, 1, 8, 19, 23, 6];
        bool sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < nums.Count - 1; i++) {
                if (nums[i] > nums[i + 1]) {
                    (nums[i + 1], nums[i]) = (nums[i], nums[i + 1]);
                    sorted = false;
                }
            }
        }

        foreach (var num in nums) {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }

    static void Two() {
        ArrayList array = [9, 32, 1, 8, 19, 23, 6];
        bool sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < array.Count - 1; i++) {
                if (((IComparable?)array[i]).CompareTo(array[i + 1]) > 0) {
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);
                    sorted = false;
                }
            }
        }


        foreach (var num in array) {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        int count = 0;
        foreach (char c in input) {
            count++;
        }
        Console.WriteLine($"Result: {count}\n");
    }

    static void Four() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        string res = "";
        for (int i = input.Length - 1; i >= 0; i--) {
            res += input[i] + " ";
        }
        Console.WriteLine($"Result: {res}\n");
    }

    static void Five() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Result: {input.Length}\n");
    }


    static void Six() {
        Console.Write("Enter first sentence: ");
        string? input1 = Console.ReadLine();
        Console.Write("Enter second sentence: ");
        string? input2 = Console.ReadLine();
        int len1 = input1.Length;
        int len2 = input2.Length;
        int minLen = Math.Min(len1, len2);
        for (int i = 0; i < minLen; i++) {
            if (input1[i] < input2[i]) {
                Console.WriteLine("First is smaller than second");
                return;
            } else if (input1[i] > input2[i]) {
                Console.WriteLine("First is greater than second");
                return;
            }
        }

        if (len1 < len2) {
            Console.WriteLine("First is smaller than second");
        } else if (len1 > len2) {
            Console.WriteLine("First is greater than second");
        } else {
            Console.WriteLine("Equal");
        }
    
    }

    static void Seven() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        int letterCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        foreach (char c in input) {
            if (char.IsLetter(c)) {
                letterCount++;
            } else if (char.IsDigit(c)) {
                digitCount++;
            } else if (!char.IsWhiteSpace(c)) {
                specialCharCount++;
            }
        }

        Console.WriteLine("Letter count: " + letterCount);
        Console.WriteLine("Number count: " + digitCount);
        Console.WriteLine("Special character count: " + specialCharCount);
    }

    static void Eight() {
        Console.Write("Enter sentence: ");
        string? input = Console.ReadLine();
        string? res = input;
        Console.WriteLine($"Result: {res}\n");
    }

    static void Nine() {
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

        Console.WriteLine($"Vowels: {res}");
        Console.WriteLine($"Consonants: {input.Length - res}\n");
        Console.WriteLine();
    }

    static void Ten() {
        One();
    }
}