class Func {
    private int a;
    private int b;
    private int c;

    public Func(int a, int b, int c) {
        if (a == 0) {
            throw new Exception("A cannot be zero");
        }

        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double FindD() {
        return b * b - 4 * a * c;
    }

    public double[] Solve() {
        double D = b * b - 4 * a * c;
        if (D < 0) {
            return [];
        } else if (D == 0) {
            double x = -b / (2 * a);
            return [x];
        } else {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return [x1, x2];
        }
    }
}

class Code {
    static void Main() {
        try {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Func func = new Func(a, b, c);

            double[] res = func.Solve();
            foreach (double i in res) {
                Console.WriteLine($"Решение: {i}");
            }
        } catch (Exception ex) {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}