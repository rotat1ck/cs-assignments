class Rectangle : Shape {
    double width;
    double height;

    public Rectangle(double width, double height) {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea() {
        return width * height;
    }
}

class Circle : Shape {
    double r;

    public Circle(double r) {
        this.r = r;
    }

    public override double CalculateArea() {
        return Math.PI * r * r;
    }
}