using System.Formats.Asn1;

namespace Shapes;

public abstract class Shapes2D
{
    public decimal Area { get; set; }
    public decimal Perimeter { get; set; }
    public abstract decimal FindArea();
    public abstract decimal FindPerimeter();
}

public abstract class Shapes3D
{
    public decimal SurfaceArea { get; set; }
    public decimal Volume { get; set; }
    public abstract decimal FindVolume();
    public abstract decimal FindSurfaceAre();
}

public class Circle : Shapes2D
{
    private decimal _radius;
    public decimal Radius
    {
        get { return _radius; }
        set
        {
            if (value is decimal and >= 0)
            {
                _radius = value;
            }
        }
    }
    public override decimal FindArea()
    {
        Area = (decimal)Math.PI * Radius * Radius;
        return Area;
    }
    public override decimal FindPerimeter()
    {
        Perimeter = (decimal)Math.PI * 2 * Radius;
        return Perimeter;
    }
}

public class Sqaure : Shapes2D
{
    private decimal _sideLength;
    public decimal SideLength
    {
        get { return _sideLength; }
        set
        {
            if (value is decimal and >= 0)
            {
                _sideLength = value;
            }
        }
    }
    public override decimal FindArea()
    {
        Area = SideLength * SideLength;
        return Area;
    }
    public override decimal FindPerimeter()
    {
        Perimeter = SideLength * 4;
        return Perimeter;
    }
}


public class Cube : Shapes3D

{
    private decimal _sideLength;
    public decimal SideLength
    {
        get { return _sideLength; }
        set
        {
            if (value is decimal and >= 0)
            {
                _sideLength = value;
            }
        }
    }
    public override decimal FindVolume()
    {
        Volume = SideLength * SideLength * SideLength;
        return Volume;
    }
    public override decimal FindSurfaceAre()
    {
        SurfaceArea = SideLength * SideLength * 6;
        return SurfaceArea;
    }
}

