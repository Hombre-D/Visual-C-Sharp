using System;


public abstract class ThreeDimensionalShape : Shape
{
    public abstract override decimal Area { get; }
    public abstract decimal Volume { get; }

    public override string ToString()
    {
        return base.ToString();
    }

}

