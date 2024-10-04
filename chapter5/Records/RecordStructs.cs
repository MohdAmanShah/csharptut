using System.Dynamic;

public record struct Point(double X, double Y, double Z);
public record struct Point2()
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public Point2(double x, double y, double z) : this()
    {
        X = x;
        Y = y;
        Z = z;
    }
}
public record struct Point3
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public Point3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}


public readonly record struct Point4(double X, double Y, double Z);
public readonly record struct Point5
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
    public Point5(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}