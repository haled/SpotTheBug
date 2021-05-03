namespace SpotTheBug
{
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
