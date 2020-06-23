namespace SpotTheBug
{
    public class Order
    {
	public int Quantity;
	public decimal PerItemCost;
	public string PartNumber;

	public decimal CalculateOrderAmount()
	{
	    return Quantity * PerItemCost;
	}

	public bool IsValid()
	{
	    return !string.IsNullOrEmpty(PartNumber);
	}

	public void SendOrderConfirmation(string emailAddress)
	{
	    SmtpClient client = new SmtpClient("smtp.company.com");
	    MailMessage message = new MailMessage();
	    message.To.Add(emailAddress);
	    message.From("customersupport@company.com");
	    message.Body("Thanks for your order. We are shipping item {0} now.", PartNumber);
	    client.Send(message);
	}
    }

    public class Program
    {
	public static void Main(string[] args)
	{
	    var newOrder = new Order();
	    newOrder.Quantity = 2;
	    newOrder.PerItemCost = 12.45;
	    newOrder.PartNumber = "JK-30065";
	    if(newOrder.IsValid())
	    {
	        Console.WriteLine("The order amount is {0}.", newOrder.CalculateOrderAmount());
	    }
	    newOrder.SendOrderConfirmation(args[0]);
	}
    }
}
