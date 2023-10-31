using N66_HT1.Api.Domain.Entities;

namespace N66_HT1.Api.Service.Interfaces;

public interface IAuthorService
{
    ValueTask<IEnumerable<Author>> GetAll();
    
    ValueTask<Author> GetById(Guid id);
    
    ValueTask<Author> Create(Author author);

    ValueTask<Author> Update(Author author);
    
    ValueTask<bool> Delete(Guid id);
}