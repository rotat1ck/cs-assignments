class Myexp : ApplicationException {
    private string message;
    public DateTime ExceptionTime { get; private set;}

    public Myexp() {
        message = "Exception";
        ExceptionTime = DateTime.Now;
    }

    public override string Message {
        get { return message; }
    }
}

class Myexception : ApplicationException {
    public DateTime ExceptionTime { get; private set;}

    public Myexception() : base("My excpetion") {
        ExceptionTime = DateTime.Now;
    }
}