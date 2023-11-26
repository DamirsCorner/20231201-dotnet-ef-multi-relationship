namespace EfCoreMultiRelationship;
public class Post(string title)
{
    public int PostId { get; set; }
    public string Title { get; set; } = title;
    public User? Author { get; set; }
    public List<User>? AllowedToComment { get; set; }
}
