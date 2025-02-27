interface IMyInterface {
    const int minSpeed = 0;
    static int maxSpeed = 60;

    void Move();

    string Name { get; set; }
}