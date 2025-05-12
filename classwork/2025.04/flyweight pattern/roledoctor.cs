class RoleDoctor : Flyweight {
    Flyweight flyweight;
    public RoleDoctor(Flyweight flyweight) {
        this.flyweight = flyweight;
    }

    public override void Greeting(string msg) {
        this.flyweight.Greeting(msg);
    }
}