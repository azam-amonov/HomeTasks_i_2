using HomeTask_42.N37_HT1.Models;

namespace HomeTask_42.N37_HT1.Interfaces;

public interface IUserService
{
    public void Create(User user);
    public IEnumerable<User> GetUsers();
}