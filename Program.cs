namespace ProjectLibraryGroup5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>();

            bookList.Add(new Book("Frankenstein", "Mary Shelley", 1111));
            bookList.Add(new Book("Sömngångaren", "Lars Kepler", 2222));
            bookList.Add(new Book("Möjligheter", "Aaron Andersson", 3333));

            Console.WriteLine("Välkommen till vårt bibliotek.\n");

            while (true)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1 - Lägg till en bok");
                Console.WriteLine("2 - Ta bort en bok");
                Console.WriteLine("3 - Sök efter en bok");
                Console.WriteLine("4 - Visa alla böcker");
                Console.WriteLine("5 - Låna en bok");
                Console.WriteLine("6 - Returnera en bok");
                Console.WriteLine("7 - Avsluta");

                string chooseMenuOption = Console.ReadLine()!;

                switch(chooseMenuOption)
                {
                    case "1":
                        Console.WriteLine("Skriv titeln på boken som du vill lägga till: ");
                        string newBookTitle = Console.ReadLine()!;

                        Console.WriteLine("Skriv författaren till boken som du vill lägga till: ");
                        string newBookAuthor = Console.ReadLine()!;

                        int newBookISBN;

                        while (true)
                        {
                            Console.WriteLine("Skriv ISBN-numret på boken som du vill lägga till: ");
                            string  newBookISBNStrin = Console.ReadLine()!;

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

                        break;
                    case "2": 
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

                        break;

                    case "3":
                        Console.WriteLine("\nAnge titeln på boken för att söka:");
                        string searchTitle = Console.ReadLine()!;
                        SearchBookByTitle(searchTitle, bookList);
                        
                        

                        break;

                    case "4":
                        Console.WriteLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        break;

                    case "6":
                        Console.WriteLine("Ange titlen på boken du vill returnera");
                        string bookToReturn = Console.ReadLine()!;
                        bool bookfound = false;

                        foreach (Book book in bookList)
                        {
                            if (book.BookTitle.Equals(bookToReturn, StringComparison.OrdinalIgnoreCase)) 
                            {
                                book.BookTitle = bookToReturn;
                                Console.WriteLine($" Boken '{bookToReturn}' har returnerats.");
                                bookFound = true;
                                break;

                            }
                        }
                        if (!bookfound)
                            
                        {
                            Console.WriteLine($"Boken '{bookToReturn}' hittades inte i biblioteket.");
                        }

                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Felaktigt val, försök igen. \n");
                        break;
                }
                    

            }
        }
        static void SearchBookByTitle(string titleToSearch, List<Book> BookList)
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
