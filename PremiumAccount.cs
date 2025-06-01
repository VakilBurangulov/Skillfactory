namespace Skillfactory;

public class PremiumAccount: IAccount
{
    public double Balance { get; set; }
    public double Interest { get; set; }
    
    public void CalculateInterest()
    {
        Interest = Balance * 0.8;
    }
}