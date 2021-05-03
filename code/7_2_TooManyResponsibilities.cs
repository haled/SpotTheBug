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

	public bool Submit()
        {
            // Do Something
        }

        public void Cancel()
        {
            // Do Something
        }
    }

    public static class ConfirmationManager
    {
	private static SmtpClient _client = new SmtpClient("smtp.company.com");

	public static void SendOrderConfirmation(string emailAddress, string partNum)
	{
	    MailMessage message = new MailMessage();
	    message.To.Add(emailAddress);
	    message.From("customersupport@company.com");
	    message.Body("Thanks for your order. We are shipping item {0} now.", partNum);
	    _client.Send(message);
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
                newOrder.Submit();
                ConfirmationManager.SendOrderConfirmation(args[0]);
	    }
            else
            {
                Console.WriteLine("The order was canceled.");
                newOrder.Cancel();
            }
	}
    }
}
