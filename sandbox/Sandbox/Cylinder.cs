class Cylinder
{
    private double height;
    private Circle circle;
    
    public Cylinder(double h, Circle c)
    {
        height = h;
        circle = c;
    }

    double GetVolume()
    {
        double volume = height * circle.GetArea();
        return volume;
    }

    void SetHeight()
    {

    }

    void SetCircle()
    {

    }
}