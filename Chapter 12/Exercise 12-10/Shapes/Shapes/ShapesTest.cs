using System;


class ShapesTest
{
    static void Main(string[] args)
    {
        Square square = new Square(5.5m);
        Circle circle = new Circle(5.5m);
        Console.WriteLine(square);
        Console.WriteLine(circle);
    }
}

