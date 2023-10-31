using Microsoft.EntityFrameworkCore;
using N66_HT1.Api.Domain.Entities;
using N66_HT1.Api.Persistence.DataContext;
using N66_HT1.Api.Service.Interfaces;

namespace N66_HT1.Api.Service.Services;

public class AuthorService : IAuthorService
{
    private readonly AppDbContext _appDbContext;

    public AuthorService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async ValueTask<IEnumerable<Author>> GetAll()
    {
        var result = await _appDbContext.Authors.ToListAsync();
        return result;
    }

    public async ValueTask<Author> GetById(Guid id)
    {
        var data = await _appDbContext.Authors.FirstOrDefaultAsync(author => author.Id == id);
        if (data is null)
            throw new AggregateException("Author by this id does not exist");
        return data;
    }

    public async ValueTask<Author> Create(Author authorToCreate)
    {
        var existingAuthor = await _appDbContext.Authors.FirstOrDefaultAsync(author
                        => author.FirstName == authorToCreate.FirstName && author.LastName == authorToCreate.LastName);
        if (existingAuthor is not null)
            throw new AggregateException("Author by this Name is already exists");

        await _appDbContext.Authors.AddAsync(authorToCreate);
        await _appDbContext.SaveChangesAsync();
        return authorToCreate;
    }

    public async ValueTask<Author> Update(Author authorToUpdate)
    {
        var existingAuthor = await _appDbContext.Authors.FirstOrDefaultAsync(author => author.Id == authorToUpdate.Id);
        if (existingAuthor is null)
            throw new AggregateException("Author does not exits");
        
        existingAuthor.FirstName = authorToUpdate.FirstName;
        existingAuthor.LastName = authorToUpdate.LastName;

        await _appDbContext.SaveChangesAsync();
        
        return existingAuthor;
    }

    public async ValueTask<bool> Delete(Guid id)
    {
        var authorToDelete = await _appDbContext.Authors.FirstOrDefaultAsync(author => author.Id == id);
        if (authorToDelete is null)
            throw new AggregateException("Author does not exits");

        _appDbContext.Authors.Remove(authorToDelete);
        await _appDbContext.SaveChangesAsync();
        
        return true;
    }
}