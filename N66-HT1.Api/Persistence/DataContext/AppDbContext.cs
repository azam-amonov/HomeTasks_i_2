using Microsoft.EntityFrameworkCore;
using N66_HT1.Api.Domain.Entities;

namespace N66_HT1.Api.Persistence.DataContext;

public class AppDbContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}