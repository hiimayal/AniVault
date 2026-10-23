using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Models;

namespace backend.Database.Configuration;

public class LikeConfiguration : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.ToTable("Likes");

        builder.HasKey(x => new { x.UserId, x.AnimeId });

        builder.Property(x => x.LikedAt)
            .IsRequired();

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Anime>()
            .WithMany()
            .HasForeignKey(x => x.AnimeId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
