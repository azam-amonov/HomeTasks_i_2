using Practice.Model;

namespace Practice.Services;

public interface IPostService
{
    public Post Get(Post post);
    public Post Create(Post post);
    public Post Update(Post post);
    public Post Delete(Guid id);
}