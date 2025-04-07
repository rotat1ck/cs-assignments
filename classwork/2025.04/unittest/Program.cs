class Code {
    static void Main() {
        BankAccount ba = new("Vova", 2000);

        ba.Credit(200.44);
        ba.Debit(123.33);
        Console.WriteLine($"Balance: {ba.Balance}");
    }
}