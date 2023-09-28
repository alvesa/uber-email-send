using uber_email_send.Core;

namespace uber_email_send.Services;
public class SendMailService : ISendMailService
{
    private readonly ISendMailInfra _sendMailInfra;

    public SendMailService(ISendMailInfra sendMailInfra)
    {
        _sendMailInfra = sendMailInfra;
    }

    public void sendMail(string to, string subject, string message)
    {
        _sendMailInfra.sendVendorEmail(to, subject, message);
    }
}