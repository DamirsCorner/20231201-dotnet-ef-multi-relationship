using Microsoft.EntityFrameworkCore;

namespace EfCoreMultiRelationship;
public class BloggingDbContext(DbContextOptions<BloggingDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();
}
