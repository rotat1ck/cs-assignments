abstract class WarriorFactory {
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}

class ArcFactory : WarriorFactory {
    public override Movement CreateMovement() {
        return new FlyMovement();
    }

    public override Weapon CreateWeapon() {
        return new Crossbow();
    }
}

class SwordFactory : WarriorFactory {
    public override Movement CreateMovement() {
        return new RunMovement();
    }

    public override Weapon CreateWeapon() {
        return new Sword();
    }
}