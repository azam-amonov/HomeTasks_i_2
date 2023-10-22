using Practice.Model;

namespace Practice.Services;

public class UserService : IUserService
{
    private List<User> _users;

    public UserService(List<User> users)
    {
        _users = users;
    }

    public User Get(User user)
    {
        var search = _users.Find(u => u.Id == user.Id);
        
        if (search is null)
            throw new ArgumentException("User not is not exist");

        return search;
    }

    public User Create(User user)
    {
        if (user is null)
            throw new ArgumentException("Item is not exist");
        _users.Add(user);
        
        return user;
    }

    public User Update(Guid id, User user)
    {
        var data = _users.Find(u => u.Id == id);
        
        if (data is null)
            throw new ArgumentException("User not exist");
        
        data.Id = id;
        data.FirstName = user.FirstName;
        data.LastName = user.LastName;
        data.Email = user.Email;
        data.Password = user.Password;
        data.ProfileImagePath = user.ProfileImagePath;
        
        return data;
    }

    public bool Delete(Guid id)
    {
        var data = _users.Find(u => u.Id == id);
        if (data is null)
            throw new ArgumentException("User not exist");
        
        _users.Remove(data);
        return true;
    }
}