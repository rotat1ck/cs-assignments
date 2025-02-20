using static System.Console;
class Code {
    static void Main() {
        // Point point = new() { x = 12, y = 12 };
        // WriteLine($"Start point\n{point}");

        // WriteLine(++point);
        // WriteLine(point++);

        // WriteLine(--point);
        // WriteLine(-point);

        // WriteLine($"New point\n{point}");

        // Point p1 = new() {x = 2, y = 3};
        // Point p2 = new() {x = 3, y = 1};

        // Vector v1 = new(p1, p2);
        // Vector v2 = new() {x = 2, y = 3};

        // WriteLine($"{v1}\n{v2}");
        // WriteLine($"v1 + v2 = {v1 + v2}");
        // WriteLine($"v1 - v2 = {v1 - v2}");

        // int.TryParse(Console.ReadLine(), out int n);

        // v1 *= n;
        // WriteLine($"v1 * {n} = {v1}");

        // CPoint cp = new() {x = 10, y = 10};
        // CPoint cp1 = new() {x = 10, y = 10};
        // CPoint cp2 = cp1; // ссылочный

        // WriteLine($"ReferenceEquals(cp, cp1) = {ReferenceEquals(cp, cp1)}"); // false

        // WriteLine($"ReferenceEquals(cp1, cp2) = {ReferenceEquals(cp1, cp2)}"); // true


        // SPoint sp = new() {x = 10, y = 10}; // значимый
        // SPoint sp1 = new() {x = 10, y = 10};


        // WriteLine($"ReferenceEquals(sp, sp) = {ReferenceEquals(sp, sp)}"); // false

        // WriteLine($"Equals(cp, cp1) = {Equals(cp, cp1)}"); // false

        // WriteLine($"Equals(sp, sp1) = {Equals(sp, sp1)}"); // true

        // Point point = new() {x = 10, y = 10};
        // Point point2 = new() {x = 20, y = 20};

        // // WriteLine(point.Equals(point));
        // // WriteLine(point.GetHashCode());

        // WriteLine(point);
        // WriteLine(point2);

        // WriteLine(point == point2);
        // WriteLine(point != point2);
        // WriteLine(point > point2);
        // WriteLine(point < point2);

        // WriteLine("Enter coords(x, y): ");
        // Point point = new() { 
        //     x = int.Parse(ReadLine()), 
        //     y = int.Parse(ReadLine()) 
        // };
        
        // if (point) {
        //     WriteLine("True coords");
        // } else {
        //     WriteLine("False coords");
        // }

        // Rectangle rectangle = new() { width = 5, height = 10 };
        // Square square = new() { lenght = 7 };

        // Rectangle rectSquare = square; // неявное
        // rectSquare.Draw();

        // Square squareRect = (Square)rectangle; // явное
        // squareRect.Draw();

        // WriteLine("Enter number: ");
        // int.TryParse(ReadLine(), out int number);
        // Square sq1 = number; // неявное
        // sq1.Draw();
        // number = (int)square; // явное

        // Shop laptops = new Shop(3);
        // laptops[0] = new Laptop() { Vendor = "Samsung", Price = 5200 };
        // laptops[1] = new Laptop() { Vendor = "Asus", Price = 6200 };
        // laptops[2] = new Laptop() { Vendor = "Acer", Price = 5400 };

        // try {
        //     for (int i = 0; i < laptops.Lenght; i++) {
        //         WriteLine($"{laptops[i]}");
        //     }
        // } catch (Exception ex) {
        //     WriteLine(ex.Message);
        // }

        // MultiArray multi = new MultiArray(2, 3);
        // for (int i = 0; i < multi.Row; i++, WriteLine()) {
        //     for (int j = 0; j < multi.Column; j++) {
        //         multi[i, j] = i + j;
        //         Write($"{multi[i, j]} ");
        //     }
        // }

        Shop laptops = new Shop(3);
        laptops[0] = new Laptop() { Vendor = "Samsung", Price = 5200 };
        laptops[1] = new Laptop() { Vendor = "Asus", Price = 6200 };
        laptops[2] = new Laptop() { Vendor = "Acer", Price = 5400 };

        try {
            for (int i = 0; i < laptops.Lenght; i++) {
                WriteLine($"{laptops[i]}");
            }
            WriteLine();
            WriteLine($"Asus: {laptops["Asus"]}");

            // ignore
            laptops["HP"] = new Laptop();
            
            WriteLine($"Price: 5200 {laptops[5200]}");
            WriteLine($"Price: 15200 {laptops[15200]}");

            // ignore
            laptops[15200] = new Laptop();
        } catch (Exception ex) {
            WriteLine(ex.Message);
        }
    }
}