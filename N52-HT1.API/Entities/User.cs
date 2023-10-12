using FileBaseContext.Abstractions.Models.Entity;

namespace N52_HT1.API.Entities;

public class User : IEntity, IFileSetEntity<Guid>
{
    public Guid Id { get; set; }
    
    public string FullName { get; set; }
    
    public string Email { get; set; }
}