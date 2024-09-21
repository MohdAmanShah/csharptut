interface ICalc
{
    int Add(int a, int b);
    int Sub(int a, int b);
    int Multiply(int b, int c);
    int Divide(int b, int c);
    int Modulo(int b, int c);
}


class Calc : ICalc
{
    public int Add(int a, int b) => a + b;
    public int Sub(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;
    public int Modulo(int a, int b) => a % b;
}





