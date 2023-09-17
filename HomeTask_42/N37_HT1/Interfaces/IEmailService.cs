using HomeTask_42.N37_HT1.Models;

namespace HomeTask_42.N37_HT1.Interfaces;

public interface IEmailService
{
    public IEnumerable<EmailMessage> GetMessage(IEnumerable<EmailTemplate> emailTemplates, IEnumerable<User> users);
}