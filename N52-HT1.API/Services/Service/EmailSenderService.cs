using N52_HT1.API.Entities;
using N52_HT1.API.Services.Interface;

namespace N52_HT1.API.Services.Service;

public class EmailSenderService : IEmailSenderService
{
    public ValueTask SendEmailAsync(User user)
    {
        throw new NotImplementedException();
    }
}