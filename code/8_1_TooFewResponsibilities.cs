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
    }

    public class OrderValidator
    {
        public bool IsValid(Order orderToValidate)
        {
            bool result = (orderToValidate.Quantity > 0) && (orderToValidate.PerItemCost > 0.0) && !(string.IsNullOrEmpty(orderToValidate.PartNumber);
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

	    var validator = new OrderValidator();
	    
	    if(validator.IsValid(newOrder))
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
