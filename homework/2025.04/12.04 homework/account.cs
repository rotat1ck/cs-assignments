class Account {
    string id = GenerateId();
    double balance;
    AccountType type;

    static string GenerateId() {
        return Guid.NewGuid().ToString();
    }

    public Account(AccountType type) {
        this.type = type;
        this.balance = 0;
    }

    public Account(double balance, AccountType type) {
        this.balance = balance;
        this.type = type;
    }

    public double GetBalance() => balance;

    public string GetId() => id;

    public AccountType GetAccountType() => type;

    public void Deposit(double amount) {
        balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount > balance) {
            throw new Exception("Not enough money");
        }
        balance -= amount;
    }

    public override string ToString() {
        return $"Id: {id}\nBalance: {balance}\nType: {type}";
    }
}

enum AccountType {
    Checking,
    Savings
}