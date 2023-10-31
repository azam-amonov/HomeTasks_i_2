using Microsoft.EntityFrameworkCore;
using N66_HT1.Api.Domain.Entities;
using N66_HT1.Api.Persistence.DataContext;
using N66_HT1.Api.Service.Interfaces;

namespace N66_HT1.Api.Service.Services;

public class BookService : IBookService
{
    private readonly AppDbContext _appDbContext;

    public BookService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async ValueTask<IEnumerable<Book>> GetAll()
    {
        return await _appDbContext.Books.ToListAsync();
    }

    public async ValueTask<Book> GetById(Guid id)
    {
        var result = await _appDbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
        if (result is null)
            throw new ArgumentException("Book not found");
        
        return result;
        
    }

    public async ValueTask<Book> Create(Book bookToCreate)
    {
        var existingData = await _appDbContext.Books.FirstOrDefaultAsync(book =>
                        book.Name == bookToCreate.Name && book.AuthorId == bookToCreate.AuthorId);
        
        if(existingData is not null)
            throw new AggregateException()
    }

    public ValueTask<Book> Update(Book book)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}