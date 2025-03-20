abstract class Function : IComparable<Function> {
    public double a { get; set; }
    public delegate double Calculate();
    
    public abstract double f();
    public Calculate calc;

    public Function() {
        calc = f;
    }

    public int CompareTo(Function other) {
        return this.a.CompareTo(other.a);
    }
}

class Line : Function {
    public double b { get; set; }
    public double x { get; set; }

    public Line() { }

    public Line(double a, double b, double x) {
        this.a = a;
        this.b = b;
        this.x = x;
    }

    public override double f() {
        return a * x + b;
    }
}

class Kub : Function {
    public double b { get; set; }
    public double c { get; set; }
    public double x { get; set; }

    public Kub() { }

    public Kub(double a, double b, double c, double x) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.x = x;
    }

    public override double f() {
        return a * Math.Pow(x, 3) + b * x + c;
    }
}

class Hyperbola : Function {
    public double x { get; set; }

    public Hyperbola() { }

    public Hyperbola(double a, double x) {
        this.a = a;
        this.x = x;
    }

    public override double f() {
        return a / x;
    }
}