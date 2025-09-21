namespace MovieStore.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Director { get; set; } = null!;
        public DateTime ReliaseDate { get; set; }
        public int Duration { get; set; }
    }
}
