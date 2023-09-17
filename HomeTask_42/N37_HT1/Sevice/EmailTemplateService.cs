using HomeTask_42.N37_HT1.Enums;
using HomeTask_42.N37_HT1.Interfaces;
using HomeTask_42.N37_HT1.Models;
using Message = HomeTask_42.N37_HT1.Models.MessageConstants.Message;

namespace HomeTask_42.N37_HT1.Sevice;

public class EmailTemplateService : IEmailTemplateService
{
    public IEnumerable<EmailTemplate> GetEmailTemplates(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            var fullName = $"{user.FirstName} {user.LastName}";

            if (user.Status == Status.Registered)
                yield return new EmailTemplate(Message.RegisteredBody.Replace("{{FullName}}", fullName), Message.RegisteredSubject);
            
            if(user.Status == Status.Deleted)
                yield return new EmailTemplate(Message.DeletedBody.Replace("{{FullName}}", fullName), Message.DeletedSubject);
        }
    }
}
