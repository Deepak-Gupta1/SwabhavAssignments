using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModel;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;

        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBook()
        {
            var allBook=_booksService.GetAllBooks();
            return Ok(allBook);
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _booksService.GetBookById(id);
            return Ok(book);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBooks(book);
            return Ok();
        }

        [HttpPut("update-by-id/{id}")]
        public IActionResult UpadteBookById(int id,[FromBody] BookVM book)
        {
            var updateBook=_booksService.UpdateBookbyId(id, book);
            return Ok(updateBook);
        }
        [HttpDelete("delete-by-id/{id}")]
        public IActionResult DeleteById(int id)
        {
            _booksService.DeleteBookById(id);
            return Ok();
        }
    }
}
