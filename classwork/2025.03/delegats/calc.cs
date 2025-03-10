class Calc {
    public delegate double CalcDelegate(double x, double y);
    public double Add(double x, double y) {
        return x + y;
    }

    public static double Sub(double x, double y) {
        return x - y;
    }

    public double Mul(double x, double y) {
        return x * y;
    }

    public double Div(double x, double y) {
        if (y != 0) {
            return x / y;
        }
        throw new DivideByZeroException();
    }
}
