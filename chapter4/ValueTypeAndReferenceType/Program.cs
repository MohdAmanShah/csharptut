PointInfo p = new PointInfo();
p.Coordinates.X = 23;
p.Coordinates.Y = 11;
p.PointName = "A";

ChangeDefault(ref p);
Console.WriteLine(p);

void ChangeDefault(ref PointInfo p)
{
    p.PointName = "B";
    p = new();
    p.Coordinates.X = 0;
    p.Coordinates.Y = 10;
    p.PointName = "C";
}