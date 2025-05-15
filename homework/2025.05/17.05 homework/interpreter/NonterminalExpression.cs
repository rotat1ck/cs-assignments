class NonterminalExpression : AbstractExpression {
    AbstractExpression? terminalExpression = new TerminalExpression();

    public override void Interpreter(Context context) {
        if (context.Position < context.Source.Length) {
            terminalExpression.Interpreter(context);
            if (context.Result) {
                context.Position++;
                this.Interpreter(context);
            } else {
                throw new Exception($"Interpreter error at char {context.Source[context.Position]}, index {context.Position}");
            }
        }
    }
}