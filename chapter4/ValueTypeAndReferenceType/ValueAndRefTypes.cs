public struct Point
{
    public int X;
    public int Y;
    // public PointInfo Info;

}

public class PointInfo
{
    public string PointName = String.Empty;
    public Point Coordinates;
    public override string ToString()
    {
        return String.Format("{2}({0}:{1})", Coordinates.X, Coordinates.Y, PointName);
    }
}