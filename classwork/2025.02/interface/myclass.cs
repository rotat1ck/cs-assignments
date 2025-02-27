class MyClass : IMyInterface {
    public MyClass() { }

    public void Move(int x, int y) {
        Console.WriteLine("Run");
    }

    public string Name { get; set; }
}