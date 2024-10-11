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

            while (true)
            {
                Console.WriteLine("Välkommen till vårt bibliotek");
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
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
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
                        Console.WriteLine("Felaktigt val, försök igen");
                        break;
                }
                    

            }
        }
    }
}
