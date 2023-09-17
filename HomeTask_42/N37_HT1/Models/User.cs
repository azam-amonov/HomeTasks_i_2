using HomeTask_42.N37_HT1.Enums;

namespace HomeTask_42.N37_HT1.Models;

public class User
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public Status Status { get; set; }

    public User()
    {
        
    }

    public User(long id, string firstName, string lastName,string emailAddress, Status status)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        Status = status;
    }
}