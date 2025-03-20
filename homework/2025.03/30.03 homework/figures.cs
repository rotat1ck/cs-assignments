abstract class Figure : IComparable<Figure> {
    public abstract void Print();
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public int CompareTo(Figure other) {
        return this.GetArea().CompareTo(other.GetArea());
    }
}

class Triangle : Figure {
    private double h;
    public Triangle() { }
    public Triangle(double h) {
        this.h = h;
    }
    public override void Print() {
        for (int i = 0; i < h; i++, Console.WriteLine()) {
            for (int j = 0; j < h - i - 1; j++) {
                Console.Write(" ");
            } for (int j = 0; j <= i; j++) {
                Console.Write("* ");
            }
        }
        Console.WriteLine();
    }

    public override double GetArea() {
        return Math.Sqrt(3) * h * h / 4;
    }

    public override double GetPerimeter() {
        return 3 * h;
    }
}
class Square : Figure {
    private double a;

    public Square() { }
    public Square(double a) {
        this.a = a;
    }
    public override void Print() {
        for (int i = 0; i < a; i++, Console.WriteLine()) {
            for (int j = 0; j < a; j++) {
                Console.Write("* ");
            }
        }
        Console.WriteLine();
    }

    public override double GetArea() {
        return a * a;
    }

    public override double GetPerimeter() {
        return 4 * a;
    }
}
class Rectangle : Figure {
    private double a;
    private double b;

    public Rectangle() { }
    public Rectangle(double a, double b) {
        this.a = a;
        this.b = b;
    }
    public override void Print() {
        for (int i = 0; i < a; i++, Console.WriteLine()) {
            for (int j = 0; j < b; j++) {
                Console.Write("* ");
            }
        }
        Console.WriteLine();
    }
    
    public override double GetArea() {
        return a * b;
    }

    public override double GetPerimeter(){
        return 2 * (a + b);
    }
}