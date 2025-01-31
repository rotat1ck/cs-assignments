class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            int press = GetKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ", [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
            Console.Clear();
            switch (press) {
                case 0: {
                    Zero();
                    break;
                } case 1: {
                    One();
                    break;
                } case 2: {
                    Two();
                    break;
                } case 3: {
                    Three();
                    break;
                } case 4: {
                    
                    break;
                } case 5: {
                    
                    break;
                } case 6: {
                    
                    break;
                } case 7: {
                    
                    break;
                } case 8: {
                    
                    break;
                } case 9: {
                    
                    break;
                }
            }
        }

        // 🥨
    }

    static int GetKeyPress(string msg, int[] validKeys) {
        ConsoleKeyInfo keyPressed;

        while (true) {
            Console.Write(msg);
            keyPressed = Console.ReadKey();
            Console.WriteLine();

            if (keyPressed.Key == ConsoleKey.Escape) {
                Environment.Exit(0);
            } else if (int.TryParse(keyPressed.KeyChar.ToString(), out int input)) {
                if (Array.Exists(validKeys, num => num.Equals(input))) {
                    return int.Parse(keyPressed.KeyChar.ToString());
                }
            }
            
            Console.Clear();
            Console.WriteLine("Invalid input\n");
        }
        
    }

    static void Zero() {
        double x, a;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        
        double[] res = [-1, -1];
        res[0] = 7 * Math.Pow(x, 2) + (3 * x) + 6;
        res[1] = 12 * Math.Pow(a, 2) + (7 * a) + 12;
        Console.WriteLine($"Results: a) {res[0]} b) {res[1]}");
    }

    static void One() {
        double a, b;
        Console.Write("Enter A: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Result: x = {-b / a}");
    }

    static void Two() {
        double a, b;
        Console.Write("Enter first side: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Perimeter: {a + b + Math.Sqrt(a * a + b * b)}");
    }

    static void Three() {
        double a, b, h;
        Console.Write("Enter first side: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        h = Convert.ToDouble(Console.ReadLine());

        double side = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));
        Console.WriteLine($"Perimeter: {a + b + 2 * side}");
    }
}