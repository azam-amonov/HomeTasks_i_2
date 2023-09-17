using HomeTask_42.N37_HT1.Models;

namespace HomeTask_42.N37_HT1.Interfaces;

public interface IEmailSenderService
{
    public void SendEmail (IEnumerable<EmailMessage> emailMessages);
}