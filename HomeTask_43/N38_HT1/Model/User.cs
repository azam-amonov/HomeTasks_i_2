namespace HomeTask_43.N38_HT1;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public User()
    {
        
    }

    public User(string firstName, string lastName, string emailAddress)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
    }

    public override string ToString()
    {
        return $"{Id} {FirstName} {LastName} {EmailAddress}";
    }
}
    