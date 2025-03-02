class Triangle : Figure {
    double a;
    double b;
    double c;

    public Triangle(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Perimeter() {
        return a + b + c;
    }

    public override double Area() {
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Square : Figure {
    protected double side;

    public Square(double side) {
        this.side = side;
    }

    public override double Perimeter(){
        return side * 4;
    }

    public override double Area() {
        return side * 2;
    }
}

class Romb : Square {
    public Romb(double side) : base(side) {}
}

class Rectangle : Figure {
    double width;
    double height;

    public Rectangle(double width, double height) {
        this.width = width;
        this.height = height;
    }

    public override double Perimeter() {
        return 2 * (width + height);
    }

    public override double Area() {
        return width * height;
    }
}

class Paralelogram : Figure {
    double a;
    double b;
    double h;

    public Paralelogram(double a, double b, double h) {
        this.a = a;
        this.b = b;
        this.h = h;
    }

    public override double Perimeter() {
        return 2 * (a + b);
    }

    public override double Area() {
        return a * h;
    }
}

class Trapeze : Figure {
    double a;
    double b;
    double c;
    double d;
    double h;

    public Trapeze(double a, double b, double c, double d, double h) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.h = h;
    }

    public override double Perimeter() {
        return a + b + c + d;
    }

    public override double Area() {
        return (a + c) * h / 2;
    }
}

class Circle : Figure {
    double r;

    public Circle(double r) {
        this.r = r;
    }

    public override double Perimeter() {
        return 2 * Math.PI * r;
    }

    public override double Area() {
        return Math.PI * r * r;
    }
}