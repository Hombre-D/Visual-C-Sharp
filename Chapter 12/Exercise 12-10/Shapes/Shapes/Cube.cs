using System;


public class Cube : ThreeDimensionalShape
{
    private decimal side;

    public Cube(decimal side)
    {
        Side = side;
    }

    public override decimal Area
    {
        get
        {
            return 6 * (Side * Side);
        }
    }

    public override decimal Volume
    {
        get
        {
            return (decimal)Math.Pow((double) Side, 3);
        }
    }

    public decimal Side
    {
        get
        {
            return side;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Side)} must be a positive value.");
            }

            side = value;
        }

    }

    public override string ToString() =>
        "Cube:\n" + $"Area: {Area:F2}\n" + $"Volume: {Volume:F2}\n";



}
