namespace RoastRoomBackend.Models;
public class Rating
{
    public int Id { get; set; }
    public bool IsUpvote { get; set; }
    public string AuthorName { get; set; } = "Anonymous";

    public int PostId { get; set; }
    public virtual Post Post { get; set; } = null!;
}