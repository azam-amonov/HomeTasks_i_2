namespace HomeTask_42.N37_HT1.Models;

public class EmailTemplate
{
    public string Subject { get; set; }
    public string Body { get; set; }

    public EmailTemplate()
    {
        
    }

    public EmailTemplate( string subject, string body)
    {
        Subject = subject;
        Body = body;
    }
    
}