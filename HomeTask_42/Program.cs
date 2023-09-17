using HomeTask_42.N37_HT1.Enums;
using HomeTask_42.N37_HT1.Models;
using HomeTask_42.N37_HT1.Sevice;

Console.WriteLine(" HomeTask_42");

var userService = new UserService();

var emailService = new EmailService();
var emailTemplateService = new EmailTemplateService();
var emailSenderService = new EmailSenderService();

userService.Create(new User(1,"John", "Doe", "deo@gmail.com", Status.Active));
userService.Create(new User(2,"Anna", "Doe", "deoAnna@gmail.com", Status.Deleted));
userService.Create(new User(1,"Steve", "Jobs", "jobs@gmail.com", Status.Registered));

var notificationManagementServiceService = new NotificationManagementService(userService, emailService, emailSenderService, emailTemplateService);
notificationManagementServiceService.NotifyUser();
