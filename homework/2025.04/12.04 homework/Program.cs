class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(f1 - f11): ");
            Console.Clear();
            switch (press) {
                case ConsoleKey.F1: {
                    One();
                    break;
                } case ConsoleKey.F2: {
                    Two();
                    break;
                } case ConsoleKey.F3: {
                    Three();
                    break;
                } case ConsoleKey.F4: {
                    Four();
                    break;
                } case ConsoleKey.F5: {
                    Five();
                    break;
                } case ConsoleKey.F6: {
                    Six();
                    break;
                } case ConsoleKey.F7: {
                    Seven();
                    break;
                } case ConsoleKey.F8: {
                    Eight();
                    break;
                } case ConsoleKey.F9: {
                    Nine();
                    break;
                } case ConsoleKey.F10: {
                    Ten();
                    break;
                } case ConsoleKey.F11: {
                    Eleven();
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
        try {
            Account account = new(5000, AccountType.Checking);
            //account.Withdraw(4500);
            Console.WriteLine(account);
            account.Deposit(5000);
            account.Withdraw(10000);
            Console.WriteLine(account.GetBalance());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    static void Two() {
        Archive.BubbleSort([5, 8, 9, 34, 1]);
    }

    static void Three() {
        Archive.FastSort([5, 8, 9, 34, 1]);
    }

    static void Four() {
        Archive.Lenght();
    }

    static void Five() {
        Archive.Reverse();
    }

    static void Six() {
        Archive.Count();
    }

    static void Seven() {
        Archive.Compare();
    }

    static void Eight() {
        Archive.Letters();
    }

    static void Nine() {
        Archive.Copy();
    }

    static void Ten() {
        Archive.Vowels();
    }

    static void Eleven() {
        Archive.Sort([5, 8, 9, 34, 1]);
    }
}