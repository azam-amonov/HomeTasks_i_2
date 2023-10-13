using N52_HT1.API.Entities;

namespace N52_HT1.API.Events;

public class AccountEventStore
{
    public event Func<User, ValueTask>? OnUserCreated;

    public async ValueTask CreatUserAddEventAsync(User user)
    {
        if (OnUserCreated is not null)
            await OnUserCreated(user);
    }
}