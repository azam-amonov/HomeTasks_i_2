namespace N66_HT1.Api.Domain.Entities;

public class Book
{
    public Guid Id { get; set; }

    public Guid AuthorId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Title { get; set; } = string.Empty;
}