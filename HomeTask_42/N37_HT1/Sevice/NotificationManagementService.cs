using HomeTask_42.N37_HT1.Interfaces;
using HomeTask_42.N37_HT1.Sevice;

public class NotificationManagementService: INotificationManagementService
{
    private readonly IUserService _userService;
    private readonly IEmailService _emailService;
    private readonly IEmailSenderService _emailSenderService;
    private readonly IEmailTemplateService _emailTemplateService;

    public NotificationManagementService()
    {
        
    }

    public NotificationManagementService(UserService userService, EmailService emailService, EmailSenderService emailSenderService, EmailTemplateService emailTemplateService)
    {
        _userService = userService;
        _emailService = emailService;
        _emailSenderService = emailSenderService;
        _emailTemplateService = emailTemplateService;
    }
    
    public void NotifyUser()
    {
        var users = _userService.GetUsers();
        var emailTemplate = _emailTemplateService.GetEmailTemplates(users);
        var emailMessage = _emailService.GetMessage(emailTemplate, users);
        _emailSenderService.SendEmail(emailMessage);
    }
}
