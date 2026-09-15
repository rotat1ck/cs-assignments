namespace mininal_api.Shapes;

public class Circle(double radius) : Shape
{
    private readonly double radius = radius;

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}
