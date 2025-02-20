class Code {
    static void Main() {
        Product bleach = new Chemicals(1, "Bleach", 1000, 5, "Mif");
        Process process = new Received(1, bleach, 10);
        process.Update();
        
        Process process1 = new Sold(1, bleach, 13);
        process1.Update();

        Console.WriteLine(bleach.quantity);
    }
}