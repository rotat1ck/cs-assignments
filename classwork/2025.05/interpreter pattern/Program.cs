class Code {
    static void Main() {
        // Interpreter

        Context context = new() {
            Vocabulary = 'a',
            Source = "aaa",
        };

        var expression = new NonterminalExpression();
        expression.Interpreter(context);

        Console.WriteLine(context.Result);
    }   
}