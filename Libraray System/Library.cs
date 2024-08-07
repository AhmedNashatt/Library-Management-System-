using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_System
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        // Book Management
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        public void RemoveBook(string title)
        {
            books.RemoveAll(b => b.Title == title);
            Console.WriteLine($"Book removed: {title}");
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        // Member Management
        public void RegisterMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member registered: {member.Name}");
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("Library Members:");
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }

        // Borrowing System
        public void BorrowBook(int memberId, string bookTitle)
        {
            var book = books.Find(b => b.Title == bookTitle);
            if (book != null && book.NumberOfCopies > 0)
            {
                book.NumberOfCopies--;
                Console.WriteLine($"Book borrowed: {bookTitle} by MemberID: {memberId}");
            }
            else
            {
                Console.WriteLine($"Book not available: {bookTitle}");
            }
        }

        public void ReturnBook(int memberId, string bookTitle)
        {
            var book = books.Find(b => b.Title == bookTitle);
            if (book != null)
            {
                book.NumberOfCopies++;
                Console.WriteLine($"Book returned: {bookTitle} by MemberID: {memberId}");
            }
            else
            {
                Console.WriteLine($"Book not found in library: {bookTitle}");
            }
        }
    }
}