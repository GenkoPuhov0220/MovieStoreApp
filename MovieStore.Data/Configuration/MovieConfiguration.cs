using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Data.Models;


namespace MovieStore.Data.Configuration
{
    using static Common.EntityValidationConstants.Movie;
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            //Fluent API
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder
                .Property(x => x.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLength);

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder
                .Property(x => x.Director)
                .IsRequired()
                .HasMaxLength(DirectorMaxLength);
        }
    }
}
