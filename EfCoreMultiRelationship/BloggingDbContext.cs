using Microsoft.EntityFrameworkCore;

namespace EfCoreMultiRelationship;
public class BloggingDbContext(DbContextOptions<BloggingDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Post> Posts => Set<Post>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(post => post.Author)
            .WithMany(user => user.AuthoredPosts);

        modelBuilder.Entity<Post>()
            .HasMany(post => post.AllowedToComment)
            .WithMany(user => user.AllowedToComment)
            .UsingEntity(
                "PostUser",
                entity => entity.HasOne(typeof(User)).WithMany().HasForeignKey("AllowedToCommentUserId"),
                entity => entity.HasOne(typeof(Post)).WithMany().HasForeignKey("AllowedToCommentPostId"),
                entity => entity.HasKey("AllowedToCommentUserId", "AllowedToCommentPostId"));

        base.OnModelCreating(modelBuilder);
    }
}
