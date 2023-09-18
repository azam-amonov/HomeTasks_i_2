namespace HomeTask_44.N39_HT2;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {Email}";
    }
}