using DigitalLibrary.Models.DTOs;
using DigitalLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService booksService;

        private readonly ILogger<BooksController> logger;

        public BooksController(ILogger<BooksController> logger, IBooksService booksService)
        {
            this.logger = logger;
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
        public async Task<ActionResult<Book>> AddBook(BookInput book)
        {
            var addedBook = await this.booksService.AddBookAsync(book);

            return Ok(addedBook);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await this.booksService.GetBookAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            await this.booksService.DeleteBookAsync(book);

            return NoContent();
        }
    }
}
