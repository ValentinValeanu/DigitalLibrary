using DigitalLibrary.Data;
using DigitalLibrary.Models.DTOs;
using DigitalLibrary.Services.Interfaces;

namespace DigitalLibrary.Services
{
    public class BooksService : IBooksService
    {
        public Task<List<Book>> GetBooksAsync()
        {
            return Task.FromResult(Database.Books);
        }

        public Task<Book?> GetBookAsync(int id)
        {
            return Task.FromResult(Database.Books.FirstOrDefault(b => b.Id == id));
        }

        public Task<Book> AddBookAsync(BookInput bookInput)
        {
            var book = new Book
            {
                Id = Database.Books.Max(b => b.Id) + 1,
                Title = bookInput.Title,
                Author = bookInput.Author,
                Category = bookInput.Category,
                Edition = bookInput.Edition,
                Language = bookInput.Language,
                LaunchDate = bookInput.LaunchDate,
                PageCount = bookInput.PageCount,
                Publishers = bookInput.Publishers,
                TargetGroup = bookInput.TargetGroup
            };

            Database.Books.Add(book);

            return Task.FromResult(book);
        }

        public Task DeleteBookAsync(Book book)
        {
            return Task.FromResult(Database.Books.Remove(book));
        }
    }
}
