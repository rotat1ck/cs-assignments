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
                // } case ConsoleKey.D2: {
                //     Three();
                //     break;
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
        Console.Write("Enter data: ");
        string[] input = Console.ReadLine().Split();
        double[] data = new double[input.Length];

        for(int i = 0; i < input.Length; ++i) {
            data[i] = Convert.ToDouble(input[i]);
        }

        double info = data[0];
        int count = 0;
        while (info == 0) {
            count++;
            info = data[count];
        }
        Console.WriteLine("Days without rain: " + count);
        Console.WriteLine();
    }

    static void Two() {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter data: ");
        string[] input = Console.ReadLine().Split();
        int[] data = new int[input.Length];
        
        for(int i = 0; i < input.Length; ++i) {
            data[i] = Convert.ToInt32(input[i]);
        }

        for(int i = 0; i < data.Length; ++i) {
            if (data[i] == n) {
                Console.WriteLine($"Place: {i + 1}");
                break;
            }
        }
        Console.WriteLine();
    }
}