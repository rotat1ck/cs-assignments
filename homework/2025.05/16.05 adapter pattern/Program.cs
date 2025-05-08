class Code {
    static void Main() {
        TextShape textShape = new();
        textShape.BoundingBox();

        Line line = new();
        line.BoundingBox();
        line.CreateManipulator();
    }
}