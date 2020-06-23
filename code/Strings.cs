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

    public class BetterOrderConfirmer
    {
	private const string COMPANY_DOMAIN = "company.com";
	private const string FROM_EMAIL = "customersupport@" + COMPANY_DOMAIN;
	private const string SUBJECT = "Order Confirmation";
	private const string THANK_YOU = "Thank you for your order.";
	private const string CONCLUSION = "This is an automatically generated message.";
	private const string NEWLINE = "\n";

	public void SendConfirmation(Order order)
	{
	    var confirmationMail = new Mail();
	    confirmationMail.From = FROM_EMAIL;
	    confirmationMail.Subject = SUBJECT;
	    StringBuilder message = new StringBuilder();
	    message.Append(THANK_YOU);
	    message.Append(NEWLINE);
	    message.Append(order.PartNumber);
	    message.Append(NEWLINE);
	    message.Append(CONCLUSION);
	    confirmationMail.Message = message.ToString();
	    confirmationMail.Send();
	}
    }
}
