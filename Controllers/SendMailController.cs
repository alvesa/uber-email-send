
using Microsoft.AspNetCore.Mvc;
using uber_email_send.Core;

namespace uber_email_send.Controllers;

[ApiController]
[Route("api/send-mail")]
public class SendMailController : ControllerBase
{
    private readonly ILogger<SendMailController> _logger;
    private readonly ISendMailService _sendMailService;
    public SendMailController(ILogger<SendMailController> logger, ISendMailService sendMailService)
    {
        _logger = logger;
        _sendMailService = sendMailService;
    }

    [HttpPost]
    public IActionResult SendMail([FromBody] SendMailRequest request) {
        var ( to, subject, message) = this.SendMailDestructuring(request);
        _sendMailService.sendMail(to, subject, message);
        return Ok("Email sent successfully");
    }

    private (string, string, string) SendMailDestructuring(SendMailRequest request) {
        return (request.To, request.Subject, request.Message);
    }
}