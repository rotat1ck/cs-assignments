class Warrior : Character {
    public double damage { get; set; }
    public Warrior(double hp, string name, int damage) 
        : base(hp, name) {
            this.damage = damage;
        }
}

class Mage : Character {
    public double damage { get; set; }
    public string spell { get; set; }
    public Mage(double hp, string name, int damage, string spell) 
        : base(hp, name) {
            this.damage = damage;
            this.spell = spell;
        }
}

class Dragon : Enemy {
    public double damage { get; set; }
    public Dragon(double hp, string name, int damage) 
        : base(hp, name) {
            this.damage = damage;
        }
}