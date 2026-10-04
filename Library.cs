using System;
using System.Collections.Generic;

namespace LibraryBookManagementSystem
{
    public class Library
    {
        // Collection
        private List<Book> books = new List<Book>();

        // Add Book
        public void AddBook(Book book)
        {
            books.Add(book);

            Console.WriteLine();
            Console.WriteLine("Book added successfully!");
            Console.WriteLine($"Book ID: {book.Id}");
        }

        // Display all books
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("========== ALL BOOKS ==========");

            foreach (Book book in books)
            {
                book.DisplayInfo();
            }

            Console.WriteLine($"Total Books: {Book.GetTotalBooks()}");
        }

        // Search book
        public void SearchBook(string title)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("Book Found!");

                    book.DisplayInfo();

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No book found with that title.");
            }
        }

        // Borrow book
        public void BorrowBook(int id)
        {
            Book? book = FindBookById(id);

            if (book != null)
            {
                book.BorrowBook();
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // Return book
        public void ReturnBook(int id)
        {
            Book? book = FindBookById(id);

            if (book != null)
            {
                book.ReturnBook();
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // Find book by ID
        private Book? FindBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            return null;
        }
    }
}