using System;
using System.Collections.Generic;


class ShapesTest
{
    static void Main()
    {
        var square = new Square(5.5m);
        var circle = new Circle(5.5m);
        var sphere = new Sphere(5.5m);
        var cube = new Cube(5.5m);

        Console.WriteLine("Shapes processed individually:");
        Console.WriteLine(square);
        Console.WriteLine(circle);
        Console.WriteLine(sphere);
        Console.WriteLine(cube);

        var shapes = new List<Shape>() { square, circle, sphere, cube };

        Console.WriteLine("Shapes list processed polymorphically:");
        foreach(var item in shapes)
        {
            Console.WriteLine($"Shape is a {item.GetType()}");
            if(item is TwoDimensionalShape)
            {
                Console.WriteLine($"Area: {item.Area:F2}\n");
            }
            else
            {
                var d3shape = (ThreeDimensionalShape) item;
                Console.WriteLine($"Area: {d3shape.Area:F2}");
                Console.WriteLine($"Volume: {d3shape.Volume:F2}\n");
            }
        }
        
    }
}

