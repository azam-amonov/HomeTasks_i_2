using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Abstractions.Models.FileEntry;
using FileBaseContext.Abstractions.Models.FileSet;
using FileBaseContext.Context.Models.Configurations;
using FileBaseContext.Context.Models.FileContext;
using N52_HT1.API.Entities;

namespace N52_HT1.API.DataAccess;

public class AppFileContext : FileContext, IDataContext
{
    public IFileSet<User, Guid> Users => Set<User, Guid>(nameof(Users));
    
    public AppFileContext(IFileContextOptions<IFileContext> fileContextOptions) : base(fileContextOptions)
    {
        OnSaveChanges += AddPrimaryKey;
    }

    private ValueTask AddPrimaryKey(IEnumerable<IFileSetBase> fileSets)
    {
        foreach (var fileSet in fileSets)
        foreach (var entry in fileSet.GetEntries())
        {
            if (entry is not IFileEntityEntry<IEntity> entityEntry) continue;
            if (entityEntry.State == FileEntityState.Added) entityEntry.Entity.Id = Guid.NewGuid();
            if (entry is not IFileEntityEntry<IFileSetEntity<Guid>> fileSetEntry) continue;
        }
        return new ValueTask(Task.CompletedTask);
    }
}