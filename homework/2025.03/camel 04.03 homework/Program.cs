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
        Vehicle vehicle = new();
        vehicle.Move();

        Vehicle car = new Car();
        car.Move();

        Console.WriteLine();
    }

    static void Two() {
        Shape square = new Rectangle(5, 5);
        Console.WriteLine(square.CalculateArea());

        Shape circle = new Circle(5);
        Console.WriteLine(circle.CalculateArea());
    }

    static void Three() {
        Crow crow = new();
        crow.Run();
        crow.Fly();
    }

    static void Four() {
        Mage mage = new Mage(100, "Cool mage", 20, "Fireball");
        Warrior warrior = new Warrior(120, "Warrior of underground", 35);
        Dragon dragon = new Dragon(90, "OP Dragon", 10);

        Console.WriteLine($"{warrior.name} attacks {mage.name}");
        mage.hp -= warrior.damage;
        Console.WriteLine($"{mage.name} is left with {mage.hp} hp");
        Console.WriteLine($"{mage.name} deals {mage.damage} hp using {mage.spell} to {dragon.name}");
        dragon.hp -= mage.damage;
        while (dragon.hp > 0) {
            dragon.hp -= mage.damage;
            mage.hp -= dragon.damage;
        }

        if (dragon.hp > 0) {
            Console.WriteLine($"{dragon.name} wins with {dragon.hp} hp");
        } else if (mage.hp > 0) {
            Console.WriteLine($"{mage.name} wins with {mage.hp} hp");
        }
        Console.WriteLine();
    }
}