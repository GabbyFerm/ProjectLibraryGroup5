namespace ProjectLibraryGroup5
{
    public class BookManagerMethods
    {

        public void AddNewBook(List<Book> bookList)
        {
            Console.WriteLine("Skriv titeln på boken som du vill lägga till: ");
            string newBookTitle = Console.ReadLine()!;

            Console.WriteLine("Skriv författaren till boken som du vill lägga till: ");
            string newBookAuthor = Console.ReadLine()!;

            int newBookISBN;

            while (true)
            {
                Console.WriteLine("Skriv ISBN-numret på boken som du vill lägga till: ");
                string newBookISBNStrin = Console.ReadLine()!;

                if (newBookISBNStrin.All(char.IsDigit))
                {
                    newBookISBN = Convert.ToInt32(newBookISBNStrin);
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange endast siffror för ISBN.");

                }
            }

            bool bookAlreadyExists = false;

            foreach (Book book in bookList)
            {
                if (book.BookTitle == newBookTitle || book.ISBN == newBookISBN)
                {
                    Console.WriteLine("Den här bokentiteln eller ISBN-numret finns redan i biblioteket.");
                    bookAlreadyExists = true;
                    break;
                }
            }

            if (!bookAlreadyExists)
            {
                bookList.Add(new Book(newBookTitle, newBookAuthor, newBookISBN));
                Console.WriteLine($"Du har lagt till en ny bok - Titel: {newBookTitle}, Författare: {newBookAuthor}, ISBN: {newBookISBN}");
            }
        }

        public void BookMenuOptions()
        {
            Console.WriteLine("\nVälj ett alternativ:");
            Console.WriteLine("1 - Lägg till en bok");
            Console.WriteLine("2 - Ta bort en bok");
            Console.WriteLine("3 - Sök efter en bok");
            Console.WriteLine("4 - Visa alla böcker");
            Console.WriteLine("5 - Låna en bok");
            Console.WriteLine("6 - Returnera en bok");
            Console.WriteLine("7 - Avsluta");
        }

        public void BorrowABook(List<Book> bookList)
        {
            Console.WriteLine("Ange boken du vill låna");
            string booktoBorrow = Console.ReadLine()!;
            bool borrowFound = false;

            foreach (Book book in bookList)
            {
                if (book.BookTitle.Equals(booktoBorrow, StringComparison.OrdinalIgnoreCase))
                {
                    borrowFound = true;

                    if (book.IsCheckedOut)
                    {
                        Console.WriteLine($"Boken {book.BookTitle} är utlånad");

                    }
                    else
                    {
                        Console.WriteLine($"Du har lånat '{book.BookTitle}'.\n");
                        book.IsCheckedOut = true;

                    }
                    break;

                }
            }
            if (!borrowFound)
            {
                Console.WriteLine("Boken hittades inte.\n");

            }
        }

        public void RemoveBookFromBooklist(List<Book> bookList)
        {
            Console.WriteLine("Ange titeln på boken du vill ta bort:");

            string bookToRemove = Console.ReadLine()!;
            bool bookFound = false;

            foreach (Book book in bookList)
            {
                if (book.BookTitle.Equals(bookToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    bookList.Remove(book);
                    Console.WriteLine($"{bookToRemove} har tagits bort.\n");
                    bookFound = true;
                    break;
                }
            }

            if (!bookFound)
            {
                Console.WriteLine("Boken hittades inte.");
            }
        }

        public void ReturnABorrowedBook(List<Book> bookList)
        {
            Console.WriteLine("Ange titlen på boken du vill returnera");
            string bookToReturn = Console.ReadLine()!;
            bool returnFound = false;

            foreach (Book book in bookList)
            {
                if (book.BookTitle.Equals(bookToReturn, StringComparison.OrdinalIgnoreCase))
                {
                    returnFound = true;

                    if (book.IsCheckedOut)
                    {
                        book.BookTitle = bookToReturn;
                        Console.WriteLine($" Boken '{bookToReturn}' har returnerats.");
                        book.IsCheckedOut = false;

                    }
                    else
                    {
                        Console.WriteLine($"Boken är inte utlånad.\n");
                    }
                    break;
                }


            }

            if (!returnFound)
            {
                Console.WriteLine($"Boken '{bookToReturn}' hittades inte i biblioteket.");
            }
        }

        public void SearchBookByTitle(string titleToSearch, List<Book> BookList)
        {
            var foundBook = BookList.Find(b => b.BookTitle.ToLower() == titleToSearch.ToLower());
            if (foundBook != null)
            {
                Console.WriteLine($"hittade bok: Title: {foundBook.BookTitle}, Author: {foundBook.BookAuthor}, ISBN: {foundBook.ISBN}");
            }
            else
            {
                Console.WriteLine("Boken hittades inte.");
            }
        }
    }
}