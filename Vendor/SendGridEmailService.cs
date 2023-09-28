namespace uber_email_send.Vendor;

public class SendGridEmailService : ISendMailInfra
{
    public SendGridEmailService()
    {
        Console.WriteLine("Injecting SendGridEmailService");
    }

    public void sendVendorEmail(string to, string subject, string message)
    {
        // TODO: implementation of vendor send email

        Console.WriteLine("Sending vendor email");
    }
}