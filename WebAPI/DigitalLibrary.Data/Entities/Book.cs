namespace DigitalLibrary.Data.Entities
{
    public class Book
    {
        public required int Id { get; set; }

        public required string Title { get; set; }

        public required string Author { get; set; }

        public int PageCount { get; set; }

        public int Edition { get; set; } = 1;

        public string? Language { get; set; }

        public string? Category { get; set; }

        public string? TargetGroup { get; set; }

        public List<Publisher> Publishers { get; set; } = new List<Publisher>();

        public DateTime LaunchDate { get; set; }
    }
}
