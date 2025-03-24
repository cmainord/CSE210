public class Shape(string color)
{
    private string _color = color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor()
    {

    }

    public virtual double GetArea()
    {
        return 0;
    }

}