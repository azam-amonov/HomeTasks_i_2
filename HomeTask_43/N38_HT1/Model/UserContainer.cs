using System.Collections;

namespace HomeTask_43.N38_HT1;

public class UserContainer : IEnumerable
{
    private readonly List<User> _users;

    public UserContainer()
    {
        _users = new List<User>();
    }

    public UserContainer(IEnumerable<User> usersCollection)
    {
        _users = new List<User>();
        _users.AddRange(usersCollection);
    }

    public User? this[Guid id] => _users.FirstOrDefault(user => user!.Id == id);
    
    public User? this[string keyword] => _users.FirstOrDefault(user => 
                    user.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase)|| 
                    user.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    user.EmailAddress.Contains(keyword, StringComparison.OrdinalIgnoreCase));
    
    public User this[int index] => _users.ElementAtOrDefault(index);
    public IEnumerator<User> GetEnumerator() => _users.GetEnumerator();
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}