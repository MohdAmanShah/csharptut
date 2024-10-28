int a = 23;
int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
object c = a;
Console.WriteLine(c);
c = b;
foreach (int i in (int[])c)
{
    Console.Write(i + " ");
}