// Console.Write("Enter name: ");
// string name = Console.ReadLine();
// Console.WriteLine("Hello {0}", name);

// top level не дает запуститься главной точке входа

class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            ConsoleKey press = getKeyPress("ESC - Close the program\nEnter the number of a task(1 - 5): ");
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
        try {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int num);
            BankAccount acc = new(num);
            acc.Widthdraw(500);
            Console.WriteLine("Remaining balance: {0}", acc.balance);
            acc.Widthdraw(2000);
        } catch (Excep ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }

    static void Two() {
        try {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0) {
                throw new Excep("Age cannot be negative");
            }
            Console.WriteLine("Your age is {0}", age);
        } catch (Excep ex) {
            Console.WriteLine(ex.Message);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }

    static void Three() {
        try {
            Console.WriteLine(Translator.Translate("apple"));
            Console.WriteLine(Translator.Translate("dog"));
            Console.WriteLine(Translator.Translate("car"));
        } catch (Excep ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }

    static void Four() {
        try {
            Product apples = new("Apple", 50);
            Product milk = new("Milk", 30);
            Warehouse warehouse = new();

            warehouse.AddProduct(apples, 10);
            Console.WriteLine("Total amount of apples: {0}", warehouse.GetProductQuantity(apples));
            Console.WriteLine("Total amount of milk: {0}", warehouse.GetProductQuantity(milk));

            warehouse.RemoveProduct(apples, 20);
            Console.WriteLine("Remaining apples: {0}", warehouse.GetProductQuantity(apples));
            warehouse.RemoveProduct(milk, 40);
            Console.WriteLine("Remaining milk: {0}", warehouse.GetProductQuantity(milk));
        } catch (Excep ex) {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
    }

    static void Five() {
        Room room101 = new(101, RoomType.Стандарт, 3000);
        Room room202 = new(202, RoomType.Люкс, 7000);
        Room room303 = new(303, RoomType.Президентский, 15000);

        Hotel.AddRoom(room101);
        Hotel.AddRoom(room202);
        Hotel.AddRoom(room303);

        try {
            Console.WriteLine(Hotel.BookRoom(101, DateTime.ParseExact("2025-03-05", "yyyy-MM-dd", null)));
            Console.WriteLine(Hotel.BookRoom(101, DateTime.ParseExact("2025-03-05", "yyyy-MM-dd", null)));
        } catch (Excep ex) {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(Hotel.UnbookRoom(101, DateTime.ParseExact("2025-03-05", "yyyy-MM-dd", null)));

        Console.WriteLine("Available rooms on 2025-03-05:");
        foreach (Room room in Hotel.GetAvailableRooms(DateTime.ParseExact("2025-03-05", "yyyy-MM-dd", null))) {
            Console.WriteLine($"Room {room.number} ({room.type}) - {room.price}rub. per night");
        }
    }
}