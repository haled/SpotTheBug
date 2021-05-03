namespace SpotTheBug
{
    public class InterestBearingAccount
    {
	private decimal _balance;
	private decimal _interestEarned;
	private decimal _interestRate;

	public InterestBearingAccount(decimal openingBalance, decimal interestRate)
	{
	    _balance = openingBalance;
	    _interestRate = interestRate;
	}

	public decimal CalculateInterest()
	{
	    _interestEarned = _balance * _interestRate;
	    return _interestEarned;
	}
    }

    public class Accountant
    {
	public decimal DetermineInterestEarned(InterestBearingAccount account)
	{
	    return account.CalculateInterest();
	}
    }

    public class Program
    {
	public static void Main(string[] args)
	{
	    var moneyTracker = new Accountant();
	    var account = new InterestBearingAccount(arg[0], arg[1]);  // should be done in factory
	    var interestIncome = moneyTracker.DetermineInterestEarned(account);
	    Console.WriteLine("The interest earned is {0}.", interestIncome);
	}
    }
}
