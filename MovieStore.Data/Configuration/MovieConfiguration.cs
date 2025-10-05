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

            builder
                .HasData(SeedMovies());
        }
        
        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>() 
            {
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Genre = "Sci-Fi",
                    Description = "A thief who steals corporate secrets through dream-sharing technology is given the chance to erase his criminal history.",
                    Director = "Christopher Nolan",
                    ReliaseDate = new DateTime(2010, 7, 16),
                    Duration = 148
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Director = "Frank Darabont",
                    ReliaseDate = new DateTime(1994, 9, 23),
                    Duration = 142
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Dark Knight",
                    Genre = "Action",
                    Description = "Batman faces the Joker, a criminal mastermind who plunges Gotham City into anarchy.",
                    Director = "Christopher Nolan",
                    ReliaseDate = new DateTime(2008, 7, 18),
                    Duration = 152
                },
                new Movie
                {
                    Id = 4,
                    Title = "Interstellar",
                    Genre = "Sci-Fi",
                    Description = "A team of explorers travels through a wormhole in space in an attempt to ensure humanity's survival.",
                    Director = "Christopher Nolan",
                    ReliaseDate = new DateTime(2014, 11, 7),
                    Duration = 169
                }
            };
               return movies;
        }
    }
}
