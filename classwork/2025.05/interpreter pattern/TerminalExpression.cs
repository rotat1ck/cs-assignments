class TerminalExpression : AbstractExpression {
    public override void Interpreter(Context context) {
        context.Result = context.Source[context.Position] == context.Vocabulary;
    }
}