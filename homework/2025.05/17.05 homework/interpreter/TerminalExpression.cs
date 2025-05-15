class TerminalExpression : AbstractExpression {
    public override void Interpreter(Context context) {
        foreach (var ch in context.Vocabulary) {
            context.Result = context.Source[context.Position] == ch.Key;
            if (context.Result) {
                int.TryParse(ch.Value, out int value);
                context.Translated += value;
                return;
            }
        }
    }
}