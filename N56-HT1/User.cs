namespace N56_HT1;

public class User
{
    public Guid UserId { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set;}


    public User( string firstName, string lastName, string email)
    {
        UserId = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}

