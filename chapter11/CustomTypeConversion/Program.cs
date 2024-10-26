public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows: ");
        Int32.TryParse(Console.ReadLine(), out int r);
        Console.WriteLine("Enter number of columns: ");
        Int32.TryParse(Console.ReadLine(), out int c);
        Rectangle R = new(r, c);
        R.Draw();
        Square s = (Square)R;
        s.Draw();
    }
}

public struct Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public void Draw()
    {
        for (int i = 0; i < Width + 2; i++)
        {
            for (int j = 0; j < Length + 2; j++)
            {
                if (j == 0 || j == Length + 1 || i == 0 || i == Width + 1)
                {
                    Console.Write("*  ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine();
        }
    }
    public static implicit operator Rectangle(Square s)
    {
        return new Rectangle(s.Length, s.Length * 2);
    }
}

public struct Square
{
    public int Length { get; set; }
    public Square(int lenght) : this()
    {
        Length = lenght;
    }
    public override string ToString()
    {
        return $"[{Length}]";
    }
    public void Draw()
    {
        for (int i = 0; i < Length + 2; i++)
        {
            for (int j = 0; j < Length + 2; j++)
            {
                if (j == 0 || j == Length + 1 || i == 0 || i == Length + 1)
                {
                    Console.Write("*  ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine();
        }
    }
    public static explicit operator Square(Rectangle rectangle)
    {
        return new Square(rectangle.Length);
    }

}