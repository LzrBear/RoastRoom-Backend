namespace RoastRoomBackend.Models;
public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = "";
    public string AuthorName { get; set; } = "Anonymous";

    public int PostId { get; set; }
    public virtual Post Post { get; set; } = null!;
}