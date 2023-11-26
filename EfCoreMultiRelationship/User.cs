namespace EfCoreMultiRelationship;
public class User(string name)
{
    public int UserId { get; set; }
    public string Name { get; set; } = name;
    public List<Post>? AuthoredPosts { get; set; }
    //public List<Post>? AllowedToComment { get; set; }
}
