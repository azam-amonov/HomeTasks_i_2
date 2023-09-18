namespace HomeTask_44.N39_HT1.Model;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }


    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}