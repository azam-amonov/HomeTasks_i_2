using N52_HT1.API.Entities;

namespace N52_HT1.API.Services.Interface;

public interface IEmailSenderService
{
    public ValueTask SendEmailAsync(User user);
}