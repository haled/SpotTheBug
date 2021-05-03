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
            bool result = (Quantity > 0) && (PerItemCost > 0.0) && !(string.IsNullOrEmpty(PartNumber);
            return result;
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
                newOrder.SendOrderConfirmation(args[0]);
	    }
            else
            {
                Console.WriteLine("The order was canceled.");
                newOrder.Cancel();
            }
        }
    }
}
