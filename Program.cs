namespace Skillfactory;

class Program
{
    static void Main()
    {
        IAccount salaryAccount = new SalaryAccount() {Balance = 1000, Interest = 2};
        IAccount ordinaryAccount = new OrdinaryAccount() {Balance = 1000, Interest = 2};
        IAccount premiumAccount = new PremiumAccount() {Balance = 1000, Interest = 2};
        
        salaryAccount.CalculateInterest();
        ordinaryAccount.CalculateInterest();
        premiumAccount.CalculateInterest();
        
        Console.WriteLine(salaryAccount.Interest);
        Console.WriteLine(ordinaryAccount.Interest);
        Console.WriteLine(premiumAccount.Interest);
    }
}