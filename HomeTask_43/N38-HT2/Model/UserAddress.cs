namespace HomeTask_43.N38_HT2.Model;

public class UserAddress
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public UserAddress()
    {
        
    }

    public UserAddress(string firstName, string lastName, string emailAddress)
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