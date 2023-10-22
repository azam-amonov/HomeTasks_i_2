namespace Practice.Model;

public class Post
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set;}
    public string ImagePath { get; set; }
    public Guid UserId { get; set; }

    
    public Post(string name, string description, string imagePath, Guid userId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        ImagePath = imagePath;
        UserId = userId;
    }
}