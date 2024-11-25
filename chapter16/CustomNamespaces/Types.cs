namespace CustomShapes.MyShapes;
public class Square
{
    public Square(int s) => Side = s;
    public Square() { }
    public int Side { get; set; }
    public int Area => Side * Side;
    public int Perimeter => 4 * Side;
}

public class Rectange
{
    public Rectange(int x, int y)
    {
        Length = x;
        Width = y;
    }
    public Rectange() { }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Area => Length * Width;
    public int Perimeter => 2 * (Length + Width);
}