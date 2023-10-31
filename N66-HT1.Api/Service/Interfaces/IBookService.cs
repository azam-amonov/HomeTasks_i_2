using N66_HT1.Api.Domain.Entities;

namespace N66_HT1.Api.Service.Interfaces;

public interface IBookService
{
    ValueTask<IEnumerable<Book>> GetAll();
    
    ValueTask<Book> GetById(Guid id);
    
    ValueTask<Book> Create(Book book);

    ValueTask<Book> Update(Book book);
    
    ValueTask<bool> Delete(Guid id);
}