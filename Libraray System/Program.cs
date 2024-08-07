using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            library.AddBook(new Book("Book1", "Ahmed", 5));
            library.AddBook(new Book("1984", "George Orwell", 3));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 4));

            // Registering members
            library.RegisterMember(new Member(1, "Alice"));
            library.RegisterMember(new Member(2, "Bob"));

            // Display books and members
            library.DisplayAllBooks();
            library.DisplayAllMembers();

            // Borrowing books
            library.BorrowBook(1, "Book1");
            library.BorrowBook(2, "1984");

            // Returning books
            library.ReturnBook(1, "Book1");

            // Display books after borrowing and returning
            library.DisplayAllBooks();
        }
    }
}