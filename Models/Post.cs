namespace RoastRoomBackend.Models;
public class Post
{
    public int Id { get; set; }
    public string Content { get; set; } = "";
    public string AuthorName { get; set; } = "Anonymous";

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}