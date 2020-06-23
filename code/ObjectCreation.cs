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
	public decimal DetermineInterestEarned(decimal accountBalance, decimal rate)
	{
	    decimal interestEarned = 0.0;
	    
	    if(accountBalance > 0 && rate > 0)
	    {
		var account = new InterestBearingAccount(accountBalance, rate);
		interestEarned = account.CalculateInterest();
	    }

	    return interestEarned;
	}
    }

    public class Accountant2
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
	    var moneyTracker = new Accountant2();
	    var interestIncome = moneyTracker.DetermineInterestEarned(arg[0], arg[1]);
	    Console.WriteLine("The interest earned is {0}.", interestIncome);
	}
    }
}
