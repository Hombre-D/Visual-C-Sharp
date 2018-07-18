using System;


public class Circle : TwoDimensionalShape
{
    private decimal radius;

    public Circle(decimal radius)
    {
        Radius = radius;
    }

    public override decimal Area
    {
        get
        {
            return (decimal)Math.PI * (radius * radius);
        }
    }

    public decimal Radius
    {
        get
        {
            return radius;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Circle)} must be a positive value.");
            }
            radius = value;
        }
    }

    public override string ToString() =>
        "Circle:\n" + $"Area: {Area}\n";

}

