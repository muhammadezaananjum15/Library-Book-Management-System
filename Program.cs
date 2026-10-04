using System;

namespace LibraryBookManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("      LIBRARY MANAGEMENT SYSTEM");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Add EBook");
                Console.WriteLine("2. Add Printed Book");
                Console.WriteLine("3. Display All Books");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. Borrow Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. Exit");
                Console.WriteLine("==================================");
                Console.Write("Enter your choice: ");

                string? choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddEBook(library);
                        break;

                    case "2":
                        AddPrintedBook(library);
                        break;

                    case "3":
                        library.DisplayBooks();
                        Pause();
                        break;

                    case "4":
                        SearchBook(library);
                        break;

                    case "5":
                        BorrowBook(library);
                        break;

                    case "6":
                        ReturnBook(library);
                        break;

                    case "7":
                        running = false;
                        Console.WriteLine("Thank you for using the Library Management System.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Pause();
                        break;
                }
            }
        }

        // Add EBook
        static void AddEBook(Library library)
        {
            Console.Write("Enter Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine() ?? "";

            Console.Write("Enter File Size (MB): ");
            double fileSize = Convert.ToDouble(Console.ReadLine());

            EBook ebook = new EBook(
                id,
                title,
                author,
                fileSize
            );

            library.AddBook(ebook);

            Pause();
        }

        // Add Printed Book
        static void AddPrintedBook(Library library)
        {
            Console.Write("Enter Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine() ?? "";

            Console.Write("Enter Number of Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());

            PrintedBook printedBook = new PrintedBook(
                id,
                title,
                author,
                pages
            );

            library.AddBook(printedBook);

            Pause();
        }

        // Search Book
        static void SearchBook(Library library)
        {
            Console.Write("Enter book title to search: ");

            string title = Console.ReadLine() ?? "";

            library.SearchBook(title);

            Pause();
        }

        // Borrow Book
        static void BorrowBook(Library library)
        {
            Console.Write("Enter Book ID to borrow: ");

            int id = Convert.ToInt32(Console.ReadLine());

            library.BorrowBook(id);

            Pause();
        }

        // Return Book
        static void ReturnBook(Library library)
        {
            Console.Write("Enter Book ID to return: ");

            int id = Convert.ToInt32(Console.ReadLine());

            library.ReturnBook(id);

            Pause();
        }

        // Pause program
        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}