namespace goidaNamespaceWhyDoYouEvenUseNamespacesTheyAreUseless {
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
            Figure triangle = new Triangle(7);
            triangle.Print();
            Figure square = new Square(5);
            square.Print();
            Figure rectangle = new Rectangle(5, 10);
            rectangle.Print();
        }

        static void Two() {
            Guess guess = new();
            Console.Write("Guess the number: ");
            int.TryParse(Console.ReadLine(), out int number);
            guess.Play(number);
        }

        static void Three() {
            TextGenerator textGenerator = new(5, 10, 30);
            Console.WriteLine(textGenerator.Random());
        }


        static void Four() {
            try {
                Money money = new(1000, 50);
                Money money1 = new(10000, 0);
                money -= 1000.49;
                Console.WriteLine(money);
                money /= 10;

                Console.WriteLine(money > money1);
                money += 1000;
                money *= 15;
                Console.WriteLine(money > money1);
                Console.WriteLine(money);
                money -= 100000;
            } catch (Brokey e) { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}