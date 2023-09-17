using HomeTask_42.N37_HT1.Interfaces;
using HomeTask_42.N37_HT1.Models;

namespace HomeTask_42.N37_HT1.Sevice;

public class UserService: IUserService
{
    private readonly List<User> _users;

    public UserService()
    {
        _users = new List<User>();
    }

    public void Create(User user)
    {
        _users.Add(user);
    }
    public IEnumerable<User> GetUsers()
    {
        foreach (var user in _users)
        {
            yield return user;
        }
    }
}

