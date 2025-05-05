class ConcreteHandler1 : Handler {
    public override void HandleRequest(int request) {
        if (request == 1) {
            Console.WriteLine("One");
        } else if (Successor != null) {
            Console.WriteLine("Null");
        }   
    }
}