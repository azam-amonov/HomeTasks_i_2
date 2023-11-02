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

        if (existingData is not null)
            throw new AggregateException("This book already exists");

        await _appDbContext.Books.AddAsync(bookToCreate);
        await _appDbContext.SaveChangesAsync();
        return bookToCreate;
    }

    public async ValueTask<Book> Update(Book bookToUpdate)
    {
        var existingBook = await _appDbContext.Books.FirstOrDefaultAsync(book => book.Id == bookToUpdate.Id);
        if(existingBook is null)
            throw new AggregateException("This book does not exist");
        
        existingBook.AuthorId = bookToUpdate.AuthorId;
        existingBook.Name = bookToUpdate.Name;
        existingBook.Title = bookToUpdate.Title;

        await _appDbContext.SaveChangesAsync();
        return existingBook;
    }

    public async ValueTask<bool> Delete(Guid id)
    {
        var bookToDelete = await _appDbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
        if(bookToDelete is null)
            throw new AggregateException("This book does not exist");
        
        _appDbContext.Books.Remove(bookToDelete);
        await _appDbContext.SaveChangesAsync();
        
        return true;
    }
}