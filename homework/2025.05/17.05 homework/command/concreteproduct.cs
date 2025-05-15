class ConcreteProduct : Product{
    public ConcreteProduct(Programmer programmer, string code) {
        this.programmer = programmer;
        this.code = code;
    }

    public override void Execute() {
        programmer.Operation(code);
    }

    public override void UnExecute() {
        programmer.Operation("");
    }
}