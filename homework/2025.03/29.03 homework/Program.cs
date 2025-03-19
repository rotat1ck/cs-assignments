using System.Linq;
using System.Text.RegularExpressions;
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

    static void One() {
        int[][] intervals = [[1,3], [2, 7], [8, 9]];
        SortedSet<int> res = [];
        bool intersect = false;

        for (int i = 0; i < intervals.Length; i++) {
            int[] interval = intervals[i];
            int count = 0;
            if (i + 1 < intervals.Length) {
                if (intervals[i + 1][0] <= interval[1]) {
                    intersect = true;
                }
            }
            if (intersect) {
                for (int j = interval[1]; j >= interval[0]; j--) {
                    if (count < 2) {
                        res.Add(j);
                        count++;
                    }
                }
            } else {
                for (int j = interval[0]; j <= interval[1]; j++) {
                    if (count < 2) {
                        res.Add(j);
                        count++;
                    }
                }
            }
            intersect = false;
        }

        Console.WriteLine($"Result: {res.Count()}");
    }
    

    static void Two() {
        Console.Write("Enter number of inner arrays: ");
        int.TryParse(Console.ReadLine(), out int n);
        int[][] ints = new int[n][];
        for (int i = 0; i < n; i++) {
            Console.Write($"Enter number of elements in array {i + 1}: ");
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var query = from s in input select int.Parse(s);
            ints[i] = query.ToArray();
        }

        int min = ints[0][0];
        int max = ints[0][0];
        for (int i = 0; i < ints.Length; i++) {
            for (int j = 0; j < ints[i].Length; j++) {
                if (ints[i][j] < min) {
                    min = ints[i][j];
                } else if (ints[i][j] > max) {
                    max = ints[i][j];
                }
            }
        }

        Console.WriteLine($"Min: {min}, Max: {max}\n");
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Result: {input.Length}\n");
    }

    static void Four() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        var res = from s in input select new string(s.Reverse().ToArray());
        Console.WriteLine($"Result: {string.Join(" ", res)}\n");
    }

    static void Five() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string pattern = @"[eioayu]";
        Regex regex = new(pattern, RegexOptions.IgnoreCase);
        var res = from s in input select regex.Matches(s).Count();
        Console.WriteLine($"Result: {res.Sum()}\n");
    }

    static void Six() {
        Console.Write("Enter sentence: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter substring to find: ");
        string? toFind = Console.ReadLine();

        string? pattern = toFind;
        Regex regex = new(pattern, RegexOptions.IgnoreCase);
        var res = from s in input where regex.IsMatch(s) select s;
        Console.WriteLine($"Result: {res.Count()}\n");
    }
}