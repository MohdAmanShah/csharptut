public class Program
{
    public static void Main(string[] args)
    {
        Point p = new Point(1, 1, "A");
        Point q = (Point)p.Clone();
        q.X = 2;
        q.Desp.Name = "B";
        Console.WriteLine(p);
        Console.WriteLine(q);
    }
}

class Point : ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointDesp Desp { get; set; }
    public Point(int x, int y, string name)
    {
        X = x;
        Y = y;
        Desp = new PointDesp(name);
    }
    public override string ToString()
    {
        return $"[X = {X}; Y = {Y}; Name = {Desp.Name}; Id = {Desp.Id}]";
    }

    public object Clone()
    {
        Point p = (Point)this.MemberwiseClone();
        p.Desp = new PointDesp(this.Desp.Name);
        return p;
    }
}

class PointDesp
{
    public string Name { get; set; }
    public Guid Id { get; set; }
    public PointDesp(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
}