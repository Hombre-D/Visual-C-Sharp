using System;


public abstract class TwoDimensionalShape : Shape
{

    public abstract override decimal Area { get; }

    public override string ToString()
    {
        return base.ToString();
    }

}

