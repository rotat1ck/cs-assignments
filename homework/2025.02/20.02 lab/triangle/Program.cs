class Triangle {
    private int a;
    private int b;
    private int c;
    private string type = "";

    public Triangle(int a, int b, int c) {
        if (a <= 0 || b <= 0 || c <= 0) {
            throw new Exception("Стороны треугольника должны быть больше 0");
        }

        if (a + b <= c || a + c <= b || b + c <= a) {
            throw new Exception("Сумма двух сторон треугольника должна быть больше третьей");
        }

        this.a = a;
        this.b = b;
        this.c = c;
    }

    public string Type() {
        if (a == b && b == c) {
            type += "Равносторонний, ";
        } else if (a == b || a == c || b == c) {
            type += "Равнобедренный, ";
        } else {
            type += "Разносторонний, ";
        }

        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) {
            type += "Прямоугольный";
        } else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a) {
            type += "Тупоугольный";
        } else {
            type += "Остроугольный";
        }

        return type;
    }

    public double Area() {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public int Perimeter() {
        return a + b + c;
    }
}

public class Code {
    public static void Main() {
        try {
            Console.Write("Введите длину стороны a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину стороны b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину стороны c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine($"Тип треугольника: {triangle.Type()}");
            Console.WriteLine($"Площадь треугольника: {triangle.Area()}");
            Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
        } catch (Exception ex) {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        
    }
}