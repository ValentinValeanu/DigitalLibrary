using DigitalLibrary.Data;
using DigitalLibrary.Data.Entities;
using DigitalLibrary.Services.Interfaces;
using DigitalLibrary.Services.Models;

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

        public Task<Book> CreateBookAsync(BookInput bookInput)
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
                TargetGroup = bookInput.TargetGroup
            };

            Database.Books.Add(book);

            return Task.FromResult(book);
        }

        public Task UpdateBookAsync(int id, BookInput bookInput)
        {
            var book = Database.Books.Find(b => b.Id == id);

            book.Title = bookInput.Title;
            book.Author = bookInput.Author;
            book.Edition = bookInput.Edition;
            book.Language = bookInput.Language;
            book.LaunchDate = bookInput.LaunchDate;
            book.PageCount = bookInput.PageCount;
            book.Category = bookInput.Category;
            book.TargetGroup = bookInput.TargetGroup;

            return Task.CompletedTask;
        }

        public Task<int> DeleteBookAsync(int id)
        {
            return Task.FromResult(Database.Books.RemoveAll(b => b.Id == id));
        }
    }
}
