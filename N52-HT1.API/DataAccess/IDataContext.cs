using FileBaseContext.Abstractions.Models.FileSet;
using N52_HT1.API.Entities;

namespace N52_HT1.API.DataAccess;

public interface IDataContext
{
    IFileSet<User, Guid> Users {get; }

    ValueTask SaveChangesAsync();
}