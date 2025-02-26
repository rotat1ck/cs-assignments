class Excep : ApplicationException {
    private string message;
    public Excep(string message) => this.message = message;

    public override string Message {
        get {
            return message;
        }
    }
}