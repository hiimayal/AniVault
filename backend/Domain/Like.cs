namespace backend.Models;

public class Like
{
    public int UserId { get; set; }
    public int AnimeId { get; set; }
    public DateTime LikedAt { get; set; }
    public Like(
        int userId, 
        int animeId, 
        DateTime likedAt)
    {
        UserId = userId;
        AnimeId = animeId;
        LikedAt = likedAt;

    }

}
