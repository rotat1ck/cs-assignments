class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 3): ");
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
        int[][] intervals = [[1, 3], [2, 6], [8, 10],[15, 18]];
        List<int[]> res = [];
        bool intersect = false;

        for (int i = 0; i < intervals.Length; i++) {
            int[] interval = intervals[i];

            if (i + 1 < intervals.Length) {
                if (intervals[i + 1][0] <= interval[1]) {
                    intersect = true;
                }
            }
            
            if (intersect) {
                int[] merge = [interval[0], intervals[i + 1][1]];
                res.Add(merge);
                i++;
            } else {
                int[] single = [interval[0], interval[1]];
                res.Add(single);
            }
            intersect = false;
        }

        foreach(var item in res) {
            Console.WriteLine($"[{item[0]}, {item[1]}]");
        }
    }

    static void Two() {
        static void Backtrack(ref int[] candidates, int target, int start, ref List<int> combination, ref List<List<int>> result) {
            if (target == 0) {
                result.Add(new(combination));
                return;
            }

            for (int i = start; i < candidates.Length; i++) {
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                if (candidates[i] > target)
                    break;

                combination.Add(candidates[i]); 
                Backtrack(ref candidates, target - candidates[i], i + 1, ref combination, ref result);
                combination.RemoveAt(combination.Count - 1);
            }
        }

        int[] candidates = [10, 1, 2, 7, 6, 1, 5];
        int target = 8;

        Array.Sort(candidates);
        List<List<int>> result = [];
        List<int> combination = [];
        Backtrack(ref candidates, target, 0, ref combination, ref result);

        foreach (var item in result) {
            Console.WriteLine(string.Join(", ", item));
        }
    }

    static void Three() {
        Console.Write("Enter a number: ");
        int.TryParse(Console.ReadLine(), out int n);
        int num = 1;
        while (num <= n) {
            num *= 4;
            if (num == n) {
                Console.WriteLine(true);
                break;
            } else if (num > n) {
                Console.WriteLine(false);
                break;
            }
        }
    }

    static void Four() {
        Console.Write("Enter amount of days: ");
        int.TryParse(Console.ReadLine(), out int d);

        List<int> jobDifficulty = [1, 2, 3, 4, 5 ];
        int n = jobDifficulty.Count;
        if (n < d) { 
            Console.WriteLine(-1); return; 
        }
        int[,] dp = new int[n + 1, d + 1];

        for (int i = 0; i <= n; i++) {
            for (int j = 0; j <= d; j++) {
                dp[i, j] = int.MaxValue;
            }
        }

        dp[0, 0] = 0;
        for (int j = 1; j <= d; j++) {
            for (int i = j; i <= n; i++) {
                int maxDifficulty = 0;
                for (int k = i; k >= j; k--) {
                    maxDifficulty = Math.Max(maxDifficulty, jobDifficulty[k - 1]);
                    dp[i, j] = Math.Min(dp[i, j], dp[k - 1, j - 1] + maxDifficulty);
                }
            }
        }
        int result = dp[n, d];
        Console.WriteLine(result == int.MaxValue ? - 1 : result);
    }
}
