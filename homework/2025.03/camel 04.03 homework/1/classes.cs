class Vehicle {
    virtual public void Move() {
        Console.WriteLine("MOVEEE");
    }
}

class Car : Vehicle {
    public override void Move() {
        Console.WriteLine("CAR MOVE");
    }
}