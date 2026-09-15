namespace mininal_api.Shapes;

public class Triangle(double sideA, double sideB, double sideC) : Shape
{
    private readonly double sideA = sideA;
    private readonly double sideB = sideB;
    private readonly double sideC = sideC;

    public override double Area()
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }   
    
    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }
}
