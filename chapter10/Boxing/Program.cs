int i = 23;
object b = i;
try
{
    long c = (long)b;
}
catch (InvalidCastException c)
{
    Console.WriteLine(c.Message);
}