namespace Skillfactory;

public class OrdinaryAccount: IAccount
{
    public double Balance { get; set; }
    public double Interest { get; set; }

    public void CalculateInterest()
    {
        Interest = Balance * 0.4;
 
        if (Balance < 1000)
            Interest -= Balance * 0.2;
              
        if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}