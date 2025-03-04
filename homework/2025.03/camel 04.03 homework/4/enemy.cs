abstract class Enemy {
    public double hp { get; set; }
    public string name { get; set; }

    public Enemy(double hp, string name) {
        this.hp = hp;
        this.name = name;
    }
}