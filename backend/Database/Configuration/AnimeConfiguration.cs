using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Models;

namespace backend.Database.Configuration;

public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
{
    public void Configure(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable("Animes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
        .IsRequired();

        builder.HasIndex(x => x.Title)
        .IsUnique();

        builder.Property(x => x.Synopsis)
        .IsRequired()
        .HasMaxLength(1000);

        builder.Property(x => x.EpisodeCount)
        .IsRequired();
    }
}
