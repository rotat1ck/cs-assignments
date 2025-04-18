using System.Text;

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
        ConsoleKey press = getKeyPress("Enter the number of an action(1 - 3): ");
        switch (press) {
            case ConsoleKey.D1: {
                Create();
                return;
            } case ConsoleKey.D2: {
                Console.WriteLine(Read());
                return;
            } case ConsoleKey.D3: {
                Write();
                return;
            } default: {
                return;
            }
        }
    
        static void Create() {
            if (File.Exists("Day17.txt")) {
                Console.WriteLine("File already exists");
            } else {
                using (FileStream fs = new("Day17.txt", FileMode.Create)) { }
                Console.WriteLine("File created");
            }
        }

        static string Read() {
            if (!File.Exists("Day17.txt")) {
                Console.WriteLine("File does not exist");
                return "";
            }

            using(FileStream fs = new("Day17.txt", FileMode.Open)) {
                byte[] buffer = new byte[fs.Length];
                fs.ReadExactly(buffer, 0, (int)fs.Length);
                return Encoding.UTF8.GetString(buffer);
            }
        }

        static void Write() {
            if (!File.Exists("Day17.txt")) {
                Console.WriteLine("File does not exist");
                return;
            }

            double[,] floats = {{ 1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 }};
            int[,] ints = {{ 1, 2, 3 }, { 4, 5, 6 }};
            string firstName = "Goida";
            string lastName = "Goidovich";
            DateTime birthDate = new(1990, 1, 1);

            using (StreamWriter sr = new("Day17.txt")) {
                sr.WriteLine($"{firstName} {lastName} {birthDate.ToShortDateString()}");

                sr.WriteLine($"{floats.GetLength(0)} {floats.GetLength(1)}");

                for (int i = 0; i < floats.GetLength(0); i++) {
                    for (int j = 0; j < floats.GetLength(1); j++) {
                        sr.Write(floats[i, j] + " ");
                    }
                    sr.WriteLine();
                }

                sr.WriteLine($"{ints.GetLength(0)} {ints.GetLength(1)}");

                for (int i = 0; i < ints.GetLength(0); i++) {
                    for (int j = 0; j < ints.GetLength(1); j++) {
                        sr.Write(ints[i, j] + " ");
                    }
                }
                sr.WriteLine();
                sr.WriteLine(DateTime.Now.ToShortDateString());
            }
        }
    }

    static void Two() {

    }

    static void Three() {

    }

    static void Four() {

    }
}