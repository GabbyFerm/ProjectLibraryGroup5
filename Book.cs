using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryGroup5
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string bookTitle, string bookAuthor, int iSBN)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            ISBN = iSBN;
            IsCheckedOut = false;
        }
    }
}
