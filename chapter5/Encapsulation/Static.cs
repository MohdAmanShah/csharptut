class SavingAccount
{
    private double _currentBalance;
    private static double _interestRate = 0.04;
    public static double InterestRate
    {
        get { return _interestRate; }
        set { _interestRate = value; }
    }
    public double Balance
    {
        get { return _currentBalance; }
        set { _currentBalance = value; }
    }
}

