using System;


public class Square : TwoDimensionalShape
{
    private decimal side;

    public Square (decimal side)
    {
        Side = side;
    }

    public override decimal Area
    {
        get
        {
            return side * side;
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
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Side)} must be a positive value.");
            }

            side = value;
        }

    }

    public override string ToString() =>
        "Square:\n" + $"Area: {Area}\n";

}

