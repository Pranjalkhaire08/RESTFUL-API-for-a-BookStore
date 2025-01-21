namespace BookStore.Application_Layer
{
    public interface IBookService
    {
        List<BookViewModel> GetBooks();
        BookViewModel GetBook(int id);
        void AddBook(BookViewModel book);
        void UpdateBook(BookViewModel book);
        void DeleteBook(int id);
    }

    public class BookViewModel
    {
    }
}
