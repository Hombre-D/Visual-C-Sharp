using System;


class RectangleTest
{
    static void Main(string[] args)
    {
        Rectangle rectangle1 = new Rectangle(2.0, 4.5);
        Rectangle rectangle2 = new Rectangle(19.9, 15.4);

        try
        {
            Rectangle rectangle3 = new Rectangle(5.0, -5.5);
        }

        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(rectangle1);
        Console.WriteLine(rectangle2);
    }
}

