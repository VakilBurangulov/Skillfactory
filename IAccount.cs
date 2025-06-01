namespace Skillfactory;

public interface IAccount
{
    double Balance { get; set;}
    double Interest { get; set;}
    
    void CalculateInterest();
}