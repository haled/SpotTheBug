namespace SpotTheBug
{
    public class OrderConfirmer
    {
	public void SendConfirmation(Order order)
	{
	    var companyDomain = "company.com";
	    var subject = "Order Confirmation";
	    var thankYou = "Thank you for your order.";
	    var conclusion = "This is an automatically generated message.";

	    var confirmationMail = new Mail();
	    confirmationMail.From = "customersupport@" + companyDomain;
	    confirmationMail.Subject = subject;
	    confirmationMail.Message = thankYou + "\n" + order.PartNumber + "\n" + conclusion;
	    confirmationMail.Send("Confirmation email for order " + order.ID);
	}
    }
}
