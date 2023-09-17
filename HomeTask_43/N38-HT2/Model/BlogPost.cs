namespace HomeTask_43.N38_HT2.Model;

public class BlogPost
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Like { get; set; }
    public int Comment { get; set; }

    public BlogPost()
    {
    }

    public BlogPost(Guid id, string title, string description, int like, int comment)
    {
        Id = id;
        Title = title;
        Description = description;
        Like = like;
        Comment = comment;
    }

    public override string ToString()
    {
        return $"{Id} {Title} {Description} {Like} {Comment}";
    }
}