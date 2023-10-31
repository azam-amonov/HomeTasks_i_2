namespace N63_HT1.Api.Model;

public class StorageFile
{
    public Guid Id { get; set; }
    
    public Guid UserId {get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Path { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}