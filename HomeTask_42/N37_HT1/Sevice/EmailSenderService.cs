using HomeTask_42.N37_HT1.Interfaces;
using HomeTask_42.N37_HT1.Models;

public class EmailSenderService : IEmailSenderService
{
    public void SendEmail(IEnumerable<EmailMessage> emailMessages)
    {
        foreach (var message in emailMessages)
        {
            Console.WriteLine($"Sender: homeTask@gamil.com\n" +
                              $"Receiver: {message.ReceiverAddress}\n" +
                              $"Body: {message.Body}\n" + 
                              $"Subject: {message.Subject}\n\n");
        }
    }
}