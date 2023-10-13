using System.Linq.Expressions;
using N52_HT1.API.Entities;

namespace N52_HT1.API.Services.Interface;

public interface IUserService
{
    IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate);
    
    ValueTask<User> CreateAsync(User user);
}