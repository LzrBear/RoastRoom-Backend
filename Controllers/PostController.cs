using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoastRoomBackend.Data;
using RoastRoomBackend.Models;

[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    private readonly AppDbContext _db;
    public PostsController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> GetPosts()
    {
        var posts = await _db.Posts.Include(p => p.Comments).Include(p => p.Ratings).ToListAsync();
        return Ok(posts);
    }

    [HttpPost]
    public async Task<IActionResult> AddPost([FromBody] Post post)
    {
        _db.Posts.Add(post);
        await _db.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("{id}/rate")]
    public async Task<IActionResult> RatePost(int id, [FromBody] Rating rating)
    {
        rating.PostId = id;
        _db.Ratings.Add(rating);
        await _db.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("{id}/comment")]
    public async Task<IActionResult> AddComment(int id, [FromBody] Comment comment)
    {
        comment.PostId = id;
        _db.Comments.Add(comment);
        await _db.SaveChangesAsync();
        return Ok();
    }
}