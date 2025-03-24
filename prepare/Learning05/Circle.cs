public class Circle (string color, double radius)
: Shape(color)
{
    private double _radius = radius;

    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}