abstract class Creator {
    Product product;

    public abstract Product FactoryMethod();
    public void AnOperation() {
        product = FactoryMethod();
    }
}