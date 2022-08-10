using my_books.Data.Model;
using my_books.Data.ViewModel;

namespace my_books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBooks(BookVM book)
        {
            var _book = new Book()
            { Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead ? book.Rate : null,
                Author = book.Author,
                Genre = book.Genre,
                CoverUrl= book.CoverUrl,
                DateAdded=DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var allBooks=_context.Books.ToList();
            return allBooks;
        }
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(n => n.Id == bookId);

        public Book UpdateBookbyId(int bookId,BookVM book)
        {
            var _book=_context.Books.FirstOrDefault(n=>n.Id==bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead : null;
                _book.Rate = book.IsRead ? book.Rate : null;
                _book.Author = book.Author;
                _book.Genre = book.Genre;
                _book.CoverUrl = book.CoverUrl;
                _context.SaveChanges();

            };
            return _book;
        }

        public void DeleteBookById(int id)
        {
            var _book=_context.Books.FirstOrDefault(n=>n.Id==id);
            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
