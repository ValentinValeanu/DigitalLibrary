using DigitalLibrary.Data.Entities;
using DigitalLibrary.Services.Interfaces;
using DigitalLibrary.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalLibrary.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService booksService;

        public BooksController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await this.booksService.GetBooksAsync();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await this.booksService.GetBookAsync(id);

            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(BookInput book)
        {
            var addedBook = await this.booksService.CreateBookAsync(book);

            return Ok(addedBook);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBook(int id, BookInput bookInput)
        {
            var book = await this.booksService.GetBookAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            await this.booksService.UpdateBookAsync(id, bookInput);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var deletedEntriesCount = await this.booksService.DeleteBookAsync(id);

            return deletedEntriesCount == 0 ? NotFound() : NoContent();
        }
    }
}
