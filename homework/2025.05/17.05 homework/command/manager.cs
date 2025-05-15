class Manager {
    Programmer programmer;
    Marketing marketing;

    Product? product;

    public Manager() {
        this.programmer = new();
        this.marketing = new();
    }

    private string? Run(Product product) {
        this.product = product;
        product.Execute();
        marketing.Adverise();
        
        return programmer.code;
    }

    private string? Undo() {
        product.UnExecute();
        return programmer.code;
    }

    public string? Add(string code) {
        return Run(new ConcreteProduct(programmer, code));
    }

    public string? Cut() {
        return Undo();
    }
}