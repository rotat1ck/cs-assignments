class ClientWarrior {
    private Movement movement;
    private Weapon weapon;

    public ClientWarrior(WarriorFactory factory) {
        movement = factory.CreateMovement();
        weapon = factory.CreateWeapon();
    }

    public void Run() {
        movement.Move();
    }

    public void Hit() {
        weapon.Hit();
    }
}