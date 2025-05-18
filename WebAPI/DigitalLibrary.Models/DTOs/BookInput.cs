using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Models.DTOs
{
    public record BookInput
    {
        public required string Title { get; set; }

        public required string Author { get; set; }

        public int PageCount { get; set; }

        public int Edition { get; set; } = 1;

        public string? Language { get; set; }

        public string? Category { get; set; }

        public string? TargetGroup { get; set; }

        public List<Publisher> Publishers { get; set; }

        public DateTime LaunchDate { get; set; }
    }
}
