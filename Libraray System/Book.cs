using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_System
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfCopies { get; set; }

        public Book(string title, string author, int numberOfCopies)
        {
            Title = title;
            Author = author;
            NumberOfCopies = numberOfCopies;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - Copies: {NumberOfCopies}";
        }
    }
}