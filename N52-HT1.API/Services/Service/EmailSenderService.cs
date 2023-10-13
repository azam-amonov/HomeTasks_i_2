using System.Net;
using System.Net.Mail;
using N52_HT1.API.Entities;
using N52_HT1.API.Services.Interface;

namespace N52_HT1.API.Services.Service;

public class EmailSenderService : IEmailSenderService
{
    public async ValueTask SendEmailAsync(User user)
    {
        var smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        smtp.EnableSsl = true;

        var fullName = $"{user.FullName}";
        var mail = new MailMessage("sultonbek.rakhimov.recovery@gmail.com", user.Email);
        mail.Subject = MessageConstants.Message;
        mail.Body = MessageConstants.Body.Replace("{{FullName}}", fullName);

        await smtp.SendMailAsync(mail);
    }
}