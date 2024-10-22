using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 4));
        shapes.Add(new Rectangle("yellow", 2, 3));
        shapes.Add(new Circle("red", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}