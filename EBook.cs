using System;

namespace LibraryBookManagementSystem
{
    // Inheritance
    public class EBook : Book
    {
        // Additional property
        public double FileSize { get; set; }

        // Constructor
        public EBook(int id, string title, string author, double fileSize)
            : base(id, title, author)
        {
            FileSize = fileSize;
        }

        // Method Overriding
        public override void DisplayInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Book Type   : EBook");
            Console.WriteLine($"ID          : {Id}");
            Console.WriteLine($"Title       : {Title}");
            Console.WriteLine($"Author      : {Author}");
            Console.WriteLine($"File Size   : {FileSize} MB");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Borrowed")}");
            Console.WriteLine("--------------------------------");
        }
    }
}