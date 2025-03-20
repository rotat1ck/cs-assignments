using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
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
        Edition[] editions = [
            new Book {
                Title = "Book 1",
                Author = "Author 1",
                Year = 2000,
                Publisher = "Publisher 1"
            }, new Article {
                Title = "Article 1",
                Author = "Author 2",
                MagazineName = "Magazine 1",
                MagazineNumber = 1,
                Publisher = "Publisher 3"
            }, new Ebook {
                Title = "Ebook 1",
                Author = "Author 2",
                Link = "Link 1"
            }, new Book {
                Title = "Book 2",
                Author = "Author 1",
                Year = 2002,
                Publisher = "Publisher 2"
            }
        ];

        Console.Write("Enter author name: ");
        string? search = Console.ReadLine();

        Regex regex = new(search, RegexOptions.IgnoreCase);
        IEnumerable<Edition> query = from e in editions where regex.IsMatch(e.Author) select e;
        foreach (Edition e in query) {
            Console.WriteLine($"Match: {e}");
        }
    }

    static void Two() {
        MyArray array = new(10);
        for (int i = 0; i < 10; ++i) {
            array[i] = i;
        }
        array.Print();
    }

    static void Three() {
        Figure[] figures = [
            new Triangle(10),
            new Square(5),
            new Rectangle(3, 4),
        ];

        Array.Sort(figures);
        foreach (Figure figure in figures) {
            Console.WriteLine($"Type: {figure.GetType().Name}, Area: {figure.GetArea()}, Perimeter: {figure.GetPerimeter()}");
        }
    }

    static void Four() {
        Function[] functions = [
            new Line {
                a = 5,
                b = 2,
                x = 3
            }, new Kub {
                a = 2,
                b = 3,
                c = 4
            }, new Hyperbola {
                a = 1,
                x = 5
            }
        ];

        Array.Sort(functions);

        foreach (Function function in functions) {
            Console.WriteLine($"Type: {function.GetType().Name}, Value: {function.calc()}");
        }
    }
}