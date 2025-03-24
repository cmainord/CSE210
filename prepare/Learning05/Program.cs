using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Circle circle = new Circle("blue", 2.5);
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("yellow", 5, 3);

        List<Shape> shapes = [];
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} : {shape.GetArea()}");
        }
    }
}