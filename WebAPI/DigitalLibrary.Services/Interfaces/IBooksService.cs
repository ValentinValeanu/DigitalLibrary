
using DigitalLibrary.Models;

namespace DigitalLibrary.Services.Interfaces
{
    public interface IBooksService
    {
        public IEnumerable<Book> GetBooks();
    }
}
