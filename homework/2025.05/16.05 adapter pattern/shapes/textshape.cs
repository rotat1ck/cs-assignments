class TextShape : Shape {
    public override void BoundingBox() {
        TextView.GetExtent();
    }

    public override Shape CreateManipulator() {
        Console.WriteLine($"Create TextShape Manipulator");
        return new TextShape();
    }
}