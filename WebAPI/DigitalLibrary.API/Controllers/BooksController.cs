using DigitalLibrary.Models;
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
        public IEnumerable<Book> GetBooks()
        {
            return this.booksService.GetBooks();
        }
    }
}
