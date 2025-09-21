using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Models;
using System.Reflection;


namespace MovieStore.Data
{
    public class MovieStoreDbContext : DbContext
    {
        public MovieStoreDbContext()
        {

        }
        
        public MovieStoreDbContext(DbContextOptions options)
            : base (options)
        {

        }
        public virtual DbSet<Movie> Movies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    } 
}
