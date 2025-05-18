using DigitalLibrary.Models.DTOs;

namespace DigitalLibrary.Data
{
    public static class Database
    {
        public static List<Book> Books = new List<Book>
        {

                new Book
                {
                    Id = 0,
                    Title = "1984",
                    Author = "George Orwell",
                    Language = "English",
                    PageCount = 268,
                    LaunchDate = new DateTime(1949, 6, 8)
                },
                new Book
                {
                    Id = 1,
                    Title = "Animal Farm",
                    Author = "George Orwell",
                    Language = "English",
                    PageCount = 256,
                    LaunchDate = new DateTime(1945, 8, 17)
                },
                new Book
                {
                    Id = 2,
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Language = "English",
                    PageCount = 320,
                    Category = "Education",
                    LaunchDate = new DateTime(2018, 10, 18)
                }
        };
    }
}
