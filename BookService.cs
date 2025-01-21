
namespace BookStore.Application_Layer
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRepository = bookRepository;
        private readonly IMapper _mapper = mapper;
        private static IBookRepository bookRepository;
        private static IMapper mapper;

        public List<BookViewModel> GetBooks()
        {
            var books = _bookRepository.GetBooks();
            return _mapper.Map<List<BookViewModel>>(books);
        }

        public BookViewModel GetBook(int id)
        {
            var book = _bookRepository.GetBook(id);
            return _mapper.Map<BookViewModel>(book);
        }

        public void AddBook(BookViewModel book)
        {
            var bookEntity = _mapper.Map<Book>(book);
            _bookRepository.AddBook(bookEntity);
        }

        public void UpdateBook(BookViewModel book)
        {
            var bookEntity = _mapper.Map<Book>(book);
            _bookRepository.UpdateBook(bookEntity);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }

    internal interface IMapper
    {
        T Map<T>(object books);
    }

    internal interface IBookRepository
    {
        void AddBook(Book bookEntity);
        void DeleteBook(int id);
        object GetBook(int id);
        object GetBooks();
        void UpdateBook(Book bookEntity);
    }

    public class Book
    {
    }
}
