class Crow : IRunnable, IFlyable {
    public void Run() {
        Console.WriteLine("RUN");
    }

    public void Fly() {
        Console.WriteLine("FLY");
    }
}