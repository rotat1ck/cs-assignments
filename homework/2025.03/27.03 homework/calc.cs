static class Calc {
    public delegate double CalcDelegate(double x, double y);
    public static double Add(double x, double y) {
        return x + y;
    }

    public static double Sub(double x, double y) {
        return x - y;
    }

    public static double Mul(double x, double y) {
        return x * y;
    }

    public static double Div(double x, double y) {
        if (y != 0) {
            return x / y;
        }
        throw new DivideByZeroException();
    }
}
