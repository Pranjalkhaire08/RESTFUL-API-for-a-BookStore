namespace BookStore.Entity
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        void Add(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
