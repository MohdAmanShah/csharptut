public partial class Employee
{
    protected BenefitPackage EmpBenefits = new BenefitPackage();
    public double GetBenefitCost() => EmpBenefits.CommutePayDeduction();
    public BenefitPackage Benefits
    {
        get { return EmpBenefits; }
        set { EmpBenefits = value; }
    }
    public virtual void GiveBonus(int amount) => Pay += amount; // virtual methods
    public class BenefitPackage
    {
        public double CommutePayDeduction()
        {
            return 125.0;
        }
    }


}