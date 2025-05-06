class Code {
    static void Main() {
        Client cl = new();
        string? result = "";

        result = cl.Add("123");
        Console.WriteLine(result);

        result = cl.Add("456");
        Console.WriteLine(result);

        result = cl.Cut();
        Console.WriteLine(result);
    }
}

class Client {
    Receiver receiver;
    Invoker invoker;

    public Client() {
        this.receiver = new();
        this.invoker = new();
    }

    private string? Run(Command command) {
        invoker.SetCommand(command);
        invoker.Run();
        return receiver.value;
    }

    private string? Undo() {
        invoker.Cancel();
        return receiver.value;
    }

    public string? Add(string value) {
        return Run(new ConcreteCommand(receiver, value));
    }

    public string? Cut() {
        return Undo();
    }
}