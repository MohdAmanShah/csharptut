using Exceptions;

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
    if (i == 50)
    {
        throw new CarIsDeadException("overspeeding");
    }
}