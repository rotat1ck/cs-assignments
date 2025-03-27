class Code {
    static void Main() {
        Account acc = new(200);
        acc.Notify += Print;
        acc.Put(200);
        acc.Take(5000);
    }

    static void Print(Account sender, AccountEventArgs e) {
        Console.WriteLine(e.Message);
    }
}