namespace mininal_api.Shapes;

public class Rectangle(double width, double height) : Shape
{
    private readonly double width = width;
    private readonly double height = height;

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}
