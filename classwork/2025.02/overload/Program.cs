class Code {
    static void Main(string[] agrs) {
        // int a = 10;
        // Calc calc = new Calc();
        // calc.Add(3, 5);
        // calc.Add(1, 4, 5);
        // calc.Add(5, 6, 7, 8);
        // calc.Add(5,5, 8,5);
        // calc.Inc(ref a);

        Stat user1 = new Stat(15);
        user1.Check();
        Stat.limitAge = 10;
        user1.Check();
        
        Console.WriteLine(user1.Count);
        Stat user2 = new Stat(15);
        Console.WriteLine(user1.Count);
        Stat.AddAge();
    }
}