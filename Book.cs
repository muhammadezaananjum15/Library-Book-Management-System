using System;

namespace LibraryBookManagementSystem
{
    // Abstract class demonstrates ABSTRACTION
    public abstract class Book
    {
        // Static member
        private static int totalBooks = 0;

        // Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; private set; }

        // Constructor
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = true;

            totalBooks++;
        }

        // Abstract method
        // Child classes MUST provide their own implementation
        public abstract void DisplayInfo();

        // Borrow book
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"'{Title}' has been borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"'{Title}' is already borrowed.");
            }
        }

        // Return book
        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"'{Title}' has been returned successfully.");
            }
            else
            {
                Console.WriteLine($"'{Title}' is already available.");
            }
        }

        // Method Overloading
        public void DisplayInfo(string message)
        {
            Console.WriteLine(message);
            DisplayInfo();
        }

        // Static method
        public static int GetTotalBooks()
        {
            return totalBooks;
        }
    }
}