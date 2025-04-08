class PepsiFactory : AbstractFactory {
    public override PepsiBottle CreateBottle() {
        return new PepsiBottle();
    }

    public override PepsiWater CreateWater() {
        return new PepsiWater();
    }
}