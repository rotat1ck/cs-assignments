public class Calc {
    public void Add(int a, int b) {
        int res = a + b;
        Console.WriteLine(res);
    }
    public void Add(int a, int b, int c) {
        int res = a + b + c;
        Console.WriteLine(res);
    }
    public void Add(int a, int b, int c, int d) {
        int res = a + b + c + d;
        Console.WriteLine(res);
    }
    
    public void Add(double a, double b) {
        double res = a + b;
        Console.WriteLine(res);
    }

    public void Inc(ref int value) {
        value++;
        Console.WriteLine(value);
    }

    public void Inc(int value) {
        value++;
        Console.WriteLine(value);
    }

    public int Mult(int x, int y) {
        return x * y;
    }

    public double Mult(double a, double b) {
        return a * b;
    }
}