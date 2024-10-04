Console.Clear();
Point6 p = new Point6 { X = 24, Y = 25 };
Console.WriteLine(p.X);
Point6 p1 = new Point6(0, 0) { X = 23, Y = 11 };
Console.WriteLine(p1.X);
Point6 p2 = new Point6(PointColor.Red) { X = 23, Y = 23 };
Console.WriteLine(p2.Color);
Console.WriteLine(p2.X);