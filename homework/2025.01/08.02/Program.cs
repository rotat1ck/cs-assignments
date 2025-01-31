class Code {
    static void Main() {
        Console.Clear();
        while (true) {
            int press = GetKeyPress("ESC - Close the program\nEnter the number of a task(0 - 9): ", new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            Console.Clear();
            switch (press) {
                case 0: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You entered: " + num);
                    break;
                } case 1: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num + " is the number you've entered");
                    break;
                } case 2: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Perimeter: " + num * 4);
                    break;
                } case 3: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Diameter: " + num * 2);
                    break;
                } case 4: {
                    // оно требует разделять запятой вместо точки??? что за бред...
                    Console.Write("Enter mass: ");
                    double M = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter volume: ");
                    double V = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Density: " + (M / V));
                    break;
                } case 5: {
                    Console.Write("Enter first side: ");
                    double m1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second side: ");
                    double m2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    double side = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));
                    Console.WriteLine("Perimeter: " + (m1 + m2 + (2 * side)));
                    break;
                } case 6: {
                    Console.Write("Enter mass: ");
                    int M = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tonnes: ~" + M / 1000);
                    break;
                } case 7: {
                    Console.Write("Enter meters: ");
                    int M = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Km's: ~" + M / 1000);
                    break;
                } case 8: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tens: " + num / 10);
                    Console.WriteLine("Units: " + num % 10);
                    Console.WriteLine("Sum: " + (num / 10 + num % 10));
                    Console.WriteLine("Product: " + (num / 10 * (num % 10)));
                    break;
                } case 9: {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Reverted: " + (num % 10) + (num / 10 % 10) + (num / 100 % 10));
                    break;
                }
            }
        }

        // 🥨
    }

    static int GetKeyPress(string msg, int[] validKeys) {
    // https://learn.microsoft.com/ru-ru/dotnet/api/system.console.clear?view=net-7.0 <- cool code
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
}