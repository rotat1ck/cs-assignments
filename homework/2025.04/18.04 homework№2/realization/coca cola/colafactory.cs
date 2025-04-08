class ColaFactory : AbstractFactory {
    public override ColaBottle CreateBottle() {
        return new ColaBottle();
    }

    public override ColaWater CreateWater() {
        return new ColaWater();
    }
}