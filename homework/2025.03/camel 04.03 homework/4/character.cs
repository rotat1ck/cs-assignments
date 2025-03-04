abstract class Character {
    public double hp { get; set; }
    public string name { get; set; }

    public Character(double hp, string name) {
        this.hp = hp;
        this.name = name;
    }
}