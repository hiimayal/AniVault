namespace backend.Models;

public class UserAnime
{
    public int Id {get; set;}
    public int UserId {get; set;}
    public int AnimeId {get; set;}
    public string Status {get; set;}
    public double Rating {get; set;}
    public int CurrentEpisode {get; set;}
    public UserAnime(
        int id, 
        int userId, 
        int animeId, 
        string status, 
        double rating,
        int currentEpisode)
    {
        Id = id;
        UserId = userId;
        AnimeId = animeId;
        Status = status;
        Rating = rating;
        CurrentEpisode = currentEpisode;
    }
}
