using DigitalLibrary.Models;
using DigitalLibrary.Services.Interfaces;

namespace DigitalLibrary.Services
{
    public class BooksService : IBooksService
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Name = "1984", Author = "George Orwell", LaunchDate = new DateTime(1949, 6, 8) },
                new Book { Name = "Animal Farm", Author = "George Orwell", LaunchDate = new DateTime(1945, 8, 17) }
            };
        }
    }
}
