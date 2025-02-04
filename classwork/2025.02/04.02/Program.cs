class Code {
    static void Main(string[] args) {
        // int[] sum = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        // Sum(sum);
        // Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);
        
        int r = Factorial(-1);
        Console.WriteLine(r);

        DayTime dayTime = DayTime.Morning;

        if (dayTime == DayTime.Morning) {
            Console.WriteLine("Morning");
        } else {
            Console.WriteLine("Not Morning");
        }

        DbOp(20, 10, Operation.Mult);
    }
    static void DbOp(double x, double y, Operation op) {
        double res = op switch {
            Operation.Add => x + y,
            Operation.Sub => x - y,
            Operation.Mult => x * y,
            Operation.Div => x / y,
        };
        Console.WriteLine(res);
    }
    enum DayTime {
        Morning,
        Afternoon,
        Evening,
        Night
    }
    
    enum Operation {
        Add,
        Sub,
        Mult,
        Div
    }

    static int Factorial(int n) {
        if (n <= 1) {
            return 1;
        }
        return n * Factorial(n-1);
    }

    static void Sum(params int[] values) {
        int res = 0;
        foreach (var value in values) {
            res += value;
        }
        Console.WriteLine(res);
    }

    static void Compare (int[] num1, int[] num2) {
        int numSum1 = 0;
        int numSum2 = 0;

        foreach (var value in num1) {
            numSum1 += value;
        }

        foreach (var value in num2) {
            numSum2 += value;
        }

        if (numSum1 > numSum2) {
            Console.WriteLine($"{numSum1} > {numSum2}");
        } else if (numSum1 < numSum2){
            Console.WriteLine($"{numSum1} < {numSum2}");
        } else {
            Console.WriteLine($"{numSum1} = {numSum2}");
        }
    }
}