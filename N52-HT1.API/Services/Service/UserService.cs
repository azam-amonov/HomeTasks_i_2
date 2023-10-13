using System.Linq.Expressions;
using N52_HT1.API.DataAccess;
using N52_HT1.API.Entities;
using N52_HT1.API.Events;
using N52_HT1.API.Services.Interface;

namespace N52_HT1.API.Services.Service;

public class UserService : IUserService
{
    private IDataContext _context;
    private AccountEventStore _eventStore;

    public UserService(IDataContext context, AccountEventStore eventService)
    {
        _context = context;
        _eventStore = eventService;
    }

    public IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate) 
        => _context.Users.Where(predicate.Compile()).AsQueryable();
    

    public async ValueTask<User> CreateAsync(User user)
    {
        var entity = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        await _eventStore.CreatUserAddEventAsync(user);

        return entity.Entity;
    }
}