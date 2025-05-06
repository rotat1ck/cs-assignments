class ConcreteCommand : Command {
    public ConcreteCommand(Receiver receiver, string value) {
        this.receiver = receiver;
        this.value = value;
    }

    public override void Execute() {
        receiver.Operation('+', value);
    }

    public override void UnExecute() {
        receiver.Operation('-', value);
    }
}