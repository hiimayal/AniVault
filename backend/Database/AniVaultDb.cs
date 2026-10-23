using Microsoft.EntityFrameworkCore;
using backend.Models;
namespace backend.Database;
    public class AniVaultDb : DbContext
    {
        public AniVaultDb(DbContextOptions<AniVaultDb> options)
        : base(options)
        {
        }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAnime> UserAnimes { get; set; }
        public DbSet<Like> likes { get; set; }
    }
