namespace backend.Models;

public class Anime
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public string ImageUrl { get; set; }
    public int EpisodeCount { get; set; }

    public Anime(
        int id,
        string title,
        string synopsis,
        string imageUrl,
        int episodeCount)
    {
        Id = id;
        Title = title;
        Synopsis = synopsis;
        ImageUrl = imageUrl;
        EpisodeCount = episodeCount;
    }
}