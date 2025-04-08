class Client {
    private AbstractBottle bottle;
    private AbstractWater water;

    public Client(AbstractFactory factory) {
        bottle = factory.CreateBottle();
        water = factory.CreateWater();
    }

    public void Run() {
        bottle.Interact(water);
    }
}