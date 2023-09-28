namespace uber_email_send.Core;

public interface ISendMailService {
    void sendMail(string to, string subject, string message);
}