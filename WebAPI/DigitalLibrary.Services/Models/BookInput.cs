using DigitalLibrary.Data.Entities;

namespace DigitalLibrary.Services.Models
{
    public class BookInput
    {
        public required string Title { get; set; }

        public required string Author { get; set; }

        public int PageCount { get; set; }

        public int Edition { get; set; } = 1;

        public string? Language { get; set; }

        public string? Category { get; set; }

        public string? TargetGroup { get; set; }

        public DateTime LaunchDate { get; set; }
    }
}
