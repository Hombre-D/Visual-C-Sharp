using System;

class Rectangle
{
    private double length;
    private double width;

    public Rectangle(double length = 1, double width = 1)
    {
        Length = length;
        Width = width;
    }


    public double Length
    {
        get
        {
            return length;
        }

        set
        {
            if(value < 0.0 || value > 20.0)
            {
                throw new ArgumentOutOfRangeException(nameof(Length), value,
                    $"{nameof(Length)} must be between 0.0 and 20.0");
            }

            length = value;

        }

    }

    public double Width
    {
        get
        {
            return width;
        }

        set
        {
            if (value < 0.0 || value > 20.0)
            {
                throw new ArgumentOutOfRangeException(nameof(Width), value,
                    $"{nameof(Width)} must be between 0.0 and 20.0");
            }

            width = value;

        }
    }

    public double Perimeter
    {
        get
        {
            return 2 * (Length + Width);
        }
    }

    public double Area
    {
        get
        {
            return Length * Width;
        }
    }

    public override string ToString() =>
        $"Length: {Length}, Width: {Width}, Perimeter: {Perimeter}, Area: {Area}";
    
}

