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
        GoidaArray array = new([1, 2, 3, 4, 5]);
        Console.WriteLine(array[2]);
        Console.WriteLine(array.ElementNow);
    }

    static void Two() {
        RoflArray arr = new([4, 5, 6, 7, 8]);
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(arr[i]);
        }
    }

    static void Three() {
        StringArray arr = new(["123", "456", "goiaa"]);
        arr[2, 3] = 'd';
        Console.WriteLine(arr[2]);
    }
}