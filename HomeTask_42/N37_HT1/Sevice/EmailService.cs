using HomeTask_42.N37_HT1.Interfaces;
using HomeTask_42.N37_HT1.Models;

public class EmailService : IEmailService
{
    public IEnumerable<EmailMessage> GetMessage(IEnumerable<EmailTemplate> emailTemplates, IEnumerable<User> users)
    {
        foreach (var item in users.Zip(emailTemplates))
        {
            yield return new EmailMessage
            {
                            Body = item.Second.Subject,
                            Subject = item.Second.Body,
                            SenderAddress = item.First.EmailAddress,
                            ReceiverAddress = item.First.EmailAddress
            };
        }
    }
}