class NonterminalExpression : AbstractExpression {
    AbstractExpression? nonterminalExpression;
    AbstractExpression? terminalExpression;

    public override void Interpreter(Context context) {
        if (context.Position < context.Source.Length) {
            terminalExpression = new TerminalExpression();
            terminalExpression.Interpreter(context);
            context.Position++;
            if (context.Result) {
                //nonterminalExpression = new NonterminalExpression();
                this.Interpreter(context);
            }
        }
    }
}