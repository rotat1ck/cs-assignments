class Line : Shape {
    public override void BoundingBox() {
        Console.WriteLine($"Line BoundingBox");
    }

    public override Shape CreateManipulator() {
        Console.WriteLine($"Create Line Manipulator");
        return new Line();
    }
}