using Practice.Model;

namespace Practice.Services;

public interface IUserService
{
    public User Get(User user);
    public User Create(User user);
    public User Update(Guid id, User user);
    public bool Delete(Guid id);
}