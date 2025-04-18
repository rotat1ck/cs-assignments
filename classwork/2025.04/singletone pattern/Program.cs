class Code {
    static void Main() {
        // Computer comp = new();
        // comp.Launch("Ubuntu 22.04");
        // Console.WriteLine(comp.OS.Name);

        // comp.OS = OS.getInstance("Windows 11");
        // Console.WriteLine(comp.OS.Name);

        new Thread(() => {
            Computer comp2 = new();
            comp2.OS = OS.getInstance("Ubuntu 22.04");
            Console.WriteLine(comp2.OS.Name);
        }).Start();

        
    }
}