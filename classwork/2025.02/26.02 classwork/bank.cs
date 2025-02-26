class BankAccount {
    public int balance {get; private set;}
    
    public BankAccount(int balance) => this.balance = balance;

    public void Widthdraw(int amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
        } else {
            throw new Excep("Not enough money");
        }
    }
}