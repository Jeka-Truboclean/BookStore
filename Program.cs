using BookStore.Data;
using BookStore.Helpers;
using BookStore.Interfaces;
using BookStore.Repository;

namespace BookStore
{
    internal class Program
    {
        private static IBook _books;
        private static IAuthor _author;

        enum ShopMenu
        {
            Books, Authors, Categories, Orders, SearchAuthors, SearchBooks, SearchCategories, SearchOrders, AddBook, AddAuthor, AddCategory, AddOrder, Exit
        }
        public static ApplicationContext DbContext() => new ApplicationContextFactory().CreateDbContext();
        static async Task Main(string[] args)
        {
            //Initialize();
            //var allBooks = await _books.GetAllBooksWithAuthorsAsync();
            int input = 0;
            do
            {
                input = ConsoleHelper.Multiple.Choice(true, new ShopMenu());
                switch((ShopMenu)input)
                {

                }
            } while (true);
        }
        static void Initialize()
        {
            new DbInit().Init(DbContext());
            _books = new BookRepository();
            _author = new AuthorRepository();
        }
    }
}
