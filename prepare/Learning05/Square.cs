public class Square(string color, double side)
: Shape(color)
{
    private double _side = side;

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}