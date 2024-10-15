namespace ProjectLibraryGroup5
{
    internal class Program : BookManagerMethods
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>();
            BookManagerMethods newBookManagerMethods = new BookManagerMethods();

            bookList.Add(new Book("Frankenstein", "Mary Shelley", 1111));
            bookList.Add(new Book("Sömngångaren", "Lars Kepler", 2222));
            bookList.Add(new Book("Möjligheter", "Aaron Andersson", 3333));

            Console.WriteLine("Välkommen till vårt bibliotek.\n");

            while (true)
            {
                newBookManagerMethods.BookMenuOptions();

                string chooseMenuOption = Console.ReadLine()!;

                switch (chooseMenuOption)
                {
                    case "1":
                        newBookManagerMethods.AddNewBook(bookList);

                        break;

                    case "2":
                        newBookManagerMethods.RemoveBookFromBooklist(bookList);

                        break;

                    case "3":
                        Console.WriteLine("\nAnge titeln på boken för att söka:");
                        string searchTitle = Console.ReadLine()!;
                        newBookManagerMethods.SearchBookByTitle(searchTitle, bookList);

                        break;

                    case "4":
                        Console.WriteLine("visa alla böcker:");
                        foreach (Book book in bookList)
                        {
                            Console.WriteLine("Titel: " + book.BookTitle + " | Författare: " + book.BookAuthor + " | ISBN: " + book.ISBN);
                        }

                        break;

                    case "5":

                        newBookManagerMethods.BorrowABook(bookList);

                        break;

                    case "6":

                        newBookManagerMethods.ReturnABorrowedBook(bookList);

                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Felaktigt val, försök igen. \n");
                        break;
                }


            }
        }
    }
}
