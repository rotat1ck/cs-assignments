class Code {
    static void Main() {
        Builder builder = new ConcreteBuilder();
        Director director = new(builder);

        director.Construct();
        Product product = builder.GetResult();
        product.Show();
    }
}