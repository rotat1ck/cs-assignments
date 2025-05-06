abstract class Command {
    protected Receiver? receiver;

    protected string? value;

    public abstract void Execute();
    public abstract void UnExecute();
}