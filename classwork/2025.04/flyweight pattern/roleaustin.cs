class RoleAustin : Flyweight {
    Flyweight flyweight;
    public RoleAustin(Flyweight flyweight) {
        this.flyweight = flyweight;
    }

    public override void Greeting(string msg) {
        this.flyweight.Greeting(msg);
    }
}