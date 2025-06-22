using DigitalLibrary.Data.Entities;
using DigitalLibrary.Services.Models;

namespace DigitalLibrary.Services.Interfaces
{
    public interface IBooksService
    {
        public Task<List<Book>> GetBooksAsync();

        public Task<Book?> GetBookAsync(int id);

        public Task<Book> CreateBookAsync(BookInput book);

        public Task UpdateBookAsync(int id, BookInput book);

        public Task<int> DeleteBookAsync(int id);
    }
}
