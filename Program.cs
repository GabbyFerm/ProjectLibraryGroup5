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
                        Console.WriteLine();
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
                        foreach (Book book in bookList){
							Console.WriteLine("BookTitle--"+book.BookTitle);
						}

                        
                        break;

                    case "4":
                        Console.WriteLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        break;

                    case "6":
                        Console.WriteLine();
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
