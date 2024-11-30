using BookStore.Data;
using BookStore.Helpers;
using BookStore.Interfaces;
using BookStore.Models;
using BookStore.Repository;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Book Store";

            // Пример использования ItemsHelper
            List<MenuOption> mainMenuOptions = new()
            {
                new MenuOption { Id = 1, Value = "View Books" },
                new MenuOption { Id = 2, Value = "Add Book" },
                new MenuOption { Id = 3, Value = "Delete Book" },
                new MenuOption { Id = 4, Value = "Search Book" }
            };

            int choice = ItemsHelper.MultipleChoice(
                canCancel: true,
                items: mainMenuOptions,
                isMenu: true,
                message: "Welcome to the Book Store. Please select an option:",
                spacingPerLine: 20,
                optionsPerLine: 2
            );

            switch (choice)
            {
                case 0: // Выход из меню (Back)
                    Console.WriteLine("Exiting...");
                    break;
                case 1: // Просмотр книг
                    ViewBooks();
                    break;
                case 2: // Добавление книги
                    AddBook();
                    break;
                case 3: // Удаление книги
                    DeleteBook();
                    break;
                case 4: // Поиск книги
                    SearchBook();
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void ViewBooks()
        {
            // Заглушка для просмотра книг.
            Console.WriteLine("Books list will be displayed here.");
        }

        static void AddBook()
        {
            // Заглушка для добавления книги.
            Console.WriteLine("Adding a book...");
            string title = InputHelper.GetString("Enter the book title");
            string author = InputHelper.GetString("Enter the author's name");
            decimal price = InputHelper.GetDecimal("Enter the price");

            Console.WriteLine($"Book '{title}' by {author} added with price {price:C}.");
        }

        static void DeleteBook()
        {
            // Заглушка для удаления книги.
            Console.WriteLine("Deleting a book...");
        }

        static void SearchBook()
        {
            // Заглушка для поиска книги.
            Console.WriteLine("Searching for a book...");
        }
    }
}
