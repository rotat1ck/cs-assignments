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
        Console.Write("Enter matrix size: ");
        int.TryParse(Console.ReadLine(), out int size);

        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; ++i) {
            Console.Write($"Enter {i + 1} row: ");
            string[] input = Console.ReadLine().Split();
            for (int item = 0; item < size; ++item) {
                int.TryParse(input[item], out matrix[i, item]);
            }
        }
    

        int positive = 0;
        int negative = 0;

        for (int i = 0; i < size; ++i) {
            for (int j = 0; j < size; ++j) {
                if (matrix[i, j] < 0) {
                    negative++;
                } else if (matrix[i, j] > 0) {
                    positive++;
                } else {
                    Console.WriteLine($"Zero at: {i + 1}, {j + 1}");
                }
            }
        }

        Console.WriteLine($"Positive elements: {positive}");
        Console.WriteLine($"Negative elements: {negative}");
        Console.WriteLine();
    }

    static void Two() {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        if (input1.Length < input2.Length) {
            return;
        }

        Console.WriteLine(input1[0..input2.Length]);
        Console.WriteLine();
    }

    static void Three() {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();
        string toFind = "нн";
        int res = 0;

        int i = 0;
        while ((i = input.IndexOf(toFind, i)) != -1) {
            res++;
            i++;
        }
        

        Console.WriteLine("Result: {0}", res);
        Console.WriteLine();
    }

    static void Four() {
        string input = new string(Console.ReadLine().Reverse().ToArray());

        int i = 0;
        while (true) {
            if (input[i] == 'с' || input[i] == 'T') {
                Console.WriteLine($"Found {input[i]} at: {input.Length - i}");
                Console.WriteLine();
                return;
            } else if (i == input.Length - 1) {
                Console.WriteLine("Not found");
                Console.WriteLine();
                return;
            } else {
                i++;
            }
        }
    }

    static void Five() {
        string[] input = Console.ReadLine().Split();

        foreach (string word in input) {
            for (int ch = 0; ch < word.Length; ch++) {
                string toFind = new string(word[ch], 5);
                while (word.IndexOf(toFind, ch) != -1) {
                    Console.WriteLine($"Found 5 consecutive {word[ch]}");
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}
