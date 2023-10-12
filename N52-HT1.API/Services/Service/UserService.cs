using N52_HT1.API.Entities;
using N52_HT1.API.Services.Interface;

namespace N52_HT1.API.Services.Service;

public class UserService : IUserService
{
    public IQueryable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> CreateAsync(User user)
    {
        throw new NotImplementedException();
    }
}