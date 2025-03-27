class Account {
    // public delegate void AccountHandler(string message);
    // AccountHandler? notify;
    // public event AccountHandler? Notify {
    //     add {
    //         notify += value;
    //         Console.WriteLine($"{value.Method.Name} added");
    //     } remove {
    //         notify += value;
    //         Console.WriteLine($"{value.Method.Name} removed");
    //     }
    // }

    // изменяем делегат под класс AccountEventArgs
    public delegate void AccountHandler(Account sender, AccountEventArgs e);
    public event AccountHandler? Notify;

    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;

    public void Put(int sum) { 
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"Deposited: {sum}", sum));
    }

    public void Take(int sum) {
        if (Sum >= sum) {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Widthdrawed: {sum}", sum));
        } else {
            Notify?.Invoke(this, new AccountEventArgs($"You are broke, all your money: {Sum}", sum));
        }
    }
}