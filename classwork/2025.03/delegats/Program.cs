class Program {
    static void Main() {
        Calc calc = new();
        Console.Write("Enter an expression: ");

        string? expression = Console.ReadLine();
        char sign = ' ';

        foreach (char item in expression) {
            if (item == '+' || item == '-' || item == '*' || item == '/') {
                sign = item;
                break;
            }
        }

        try {
            string[] num = expression.Split(sign);
            Calc.CalcDelegate? del = null;

            switch (sign ) {
                case '+': {
                    del = calc.Add;
                    break;
                } case '-': {
                    del = Calc.Sub;
                    break;
                } case '*': {
                    del = calc.Mul;
                    break;
                } case '/': {
                    del = calc.Div;
                    break;
                } default: {
                    throw new InvalidOperationException();
                }
            }
            Console.WriteLine($"Result: {del(double.Parse(num[0]), double.Parse(num[1]))}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
