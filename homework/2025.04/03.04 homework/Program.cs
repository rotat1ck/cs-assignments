using System.Collections;
using System.Linq;

class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 4): ");
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
        Console.Write("Enter number of intervals: ");
        int.TryParse(Console.ReadLine(), out int n);
        int[][] intervals = new int[n][];
        for (int i = 0; i < n; i++) {
            Console.Write($"Enter number of elements in array {i + 1}: ");
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var query = from s in input select int.Parse(s);
            intervals[i] = query.ToArray();
        }

        bool intersect = false;
        List<int[]> result = [];
        for (int i = 0; i < intervals.Length; i++) {
            int[] interval = intervals[i];
            if (i + 1 < intervals.Length) {
                if (intervals[i + 1][0] <= interval[1]) {
                    intersect = true;
                }
            }
            if (intersect) {
                result.Add([interval[0], intervals[i + 1][1]]);
                i++;
            } else {
                result.Add([interval[0], interval[1]]);
            }
            intersect = false;
        }

        for (int i = 0; i < result.Count; i++) {
            Console.WriteLine($"[{string.Join(" ", result[i])}]");
        }
    }

    static void Two() {
        Console.Write("Enter candidates: ");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var query = from s in input select int.Parse(s);
        int[] candidates = query.ToArray();

        Console.Write("Enter target: ");
        int.TryParse(Console.ReadLine(), out int target);
        Dictionary<int, List<int>> result = [];

        for (int i = 0; i < candidates.Length; ++i) {
            int sum = 0;
            List<int> nums = [];
            List<int> copy = new(candidates);
            for (int j = i; j < copy.Count; ++j) {
                if (copy[j] > target) {
                    copy.RemoveAt(j);
                    continue;
                }
                Console.WriteLine(string.Join(" ", copy));
                sum += candidates[j];
                nums.Append(candidates[j]);
                
                if (sum > target) {
                    copy.RemoveAt(nums[nums.Count - 1]);
                } else if (sum == target) {
                    result.Add(result.Count + 1, nums);
                    copy.RemoveAt(nums[nums.Count - 1]);
                }
            }
        }
    }

    static void Three() {

    }

    static void Four() {

    }
}