
class Circle
{
    private double radius;

    Circle(double r)
    {
        SetRadius(r);
    }
    

    double GetArea()
    {
        double area =  Math.PI * radius * radius;
        return area;
    }

    double GetCircumference()
    {
        double circumference = 2 * radius * Math.PI;
        return circumference;
    }

    double GetDiameter()
    {
        double diameter = radius * 2;
        return diameter;
    }

    double GetRadius()
    {
        return radius;
    }

    void SetRadius(double r)
    {
        radius = r;
    }
}