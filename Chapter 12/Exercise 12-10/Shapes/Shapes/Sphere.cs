using System;


public class Sphere : ThreeDimensionalShape
{
    private decimal radius;

    public Sphere(decimal radius)
    {
        Radius = radius;
    }

    public override decimal Area
    {
        get
        {
            return (decimal)(Math.PI * 4) * (radius * radius);
        }
    }

    public override decimal Volume
    {
        get
        {
            return (4.0m / 3.0m) * (decimal) Math.PI * (decimal) Math.Pow((double)Radius, 3);
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
                    $"{nameof(Radius)} must be a positive value.");
            }
            radius = value;
        }
    }

    public override string ToString() =>
        "Sphere:\n" + $"Area: {Area:F2}\n" + $"Volume: {Volume:F2}\n";


}

