using System;

namespace LibraryBookManagementSystem
{
    // Inheritance
    public class PrintedBook : Book
    {
        // Additional property
        public int Pages { get; set; }

        // Constructor
        public PrintedBook(int id, string title, string author, int pages)
            : base(id, title, author)
        {
            Pages = pages;
        }

        // Method Overriding
        public override void DisplayInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Book Type   : Printed Book");
            Console.WriteLine($"ID          : {Id}");
            Console.WriteLine($"Title       : {Title}");
            Console.WriteLine($"Author      : {Author}");
            Console.WriteLine($"Pages       : {Pages}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Borrowed")}");
            Console.WriteLine("--------------------------------");
        }
    }
}