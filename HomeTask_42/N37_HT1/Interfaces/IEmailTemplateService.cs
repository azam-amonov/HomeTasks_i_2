using HomeTask_42.N37_HT1.Models;

namespace HomeTask_42.N37_HT1.Interfaces;

public interface IEmailTemplateService
{
    public IEnumerable<EmailTemplate> GetEmailTemplates(IEnumerable<User> users);
}