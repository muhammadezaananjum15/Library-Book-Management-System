# Library Book Management System

A C# Console Application built to demonstrate core **Object-Oriented Programming (OOP)** concepts through a practical library management system.

## Features

* Add EBooks and Printed Books
* Display all books
* Search books by title
* Borrow and return books
* Track book availability
* Manage books using `List<Book>`
* Demonstrate different book types through inheritance

## OOP Concepts

| Concept        | Implementation                            |
| -------------- | ----------------------------------------- |
| Class & Object | `Book`, `EBook`, `PrintedBook`, `Library` |
| Properties     | `Id`, `Title`, `Author`, `IsAvailable`    |
| Constructor    | Initializes book objects                  |
| Encapsulation  | Private setter for `IsAvailable`          |
| Inheritance    | `EBook : Book`, `PrintedBook : Book`      |
| Overloading    | Multiple `DisplayInfo()` signatures       |
| Overriding     | Child classes override `DisplayInfo()`    |
| Abstraction    | Abstract `Book` class                     |
| Polymorphism   | `List<Book>` stores different book types  |
| Static Members | Tracks total books                        |
| Collections    | `List<Book>`                              |
| Searching      | Search by title                           |

## Project Structure

```text
LibraryBookManagementSystem/
├── Book.cs
├── EBook.cs
├── PrintedBook.cs
├── Library.cs
├── Program.cs
└── LibraryBookManagementSystem.csproj
```

## Menu

```text
LIBRARY MANAGEMENT SYSTEM

1. Add EBook
2. Add Printed Book
3. Display All Books
4. Search Book
5. Borrow Book
6. Return Book
7. Exit
```

## Technologies

* C#
* .NET
* OOP
* Console Application
* `List<T>`

## Run

```bash
dotnet build
dotnet run
```

## Purpose

Built as a practical C# OOP project to demonstrate how fundamental OOP concepts work together in a real-world application.

## Author

**Muhammad Ezaan Anjum**
