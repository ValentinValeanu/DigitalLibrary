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


        public Task DeleteBookAsync(Book book)
        {
            return Task.FromResult(Database.Books.Remove(book));
        }
    }
}
