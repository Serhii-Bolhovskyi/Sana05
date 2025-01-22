namespace Sana05;
using Classes;

class Program
{
    static void Main(string[] args)
    {
        List<LibraryItem> FindAvailableItems(List<LibraryItem> items)
        {
            return items.Where(item => !item.IsBorrowed).ToList();
        }
        
        List<LibraryItem> libraryItems = new List<LibraryItem>();
        libraryItems.Add(new Book("Green Mile", "Stephen King", 1996, 305));
        libraryItems.Add(new Journal("Times", "John L", 2022, "2025 jan"));
        libraryItems.Add( new EBook("Main Adventure", "Sara Mayer", 2024, "pdf"));
        

        // libraryItems[0].Borrow("Serhii");
        
        foreach (LibraryItem item in libraryItems)
            {
                /* old way  
                if (atm is Terminal)
                    (atm as Terminal).DisplayMenu();*/
                /* modern way */
                (item as Book)?.Borrow("Serhii");
            }
        
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Show all elements in list: ");
            Console.WriteLine("2. Show only items available for borrowing: ");
            Console.WriteLine("3. Borrow an item (by title): ");
            Console.WriteLine("4. Return the item (by title): ");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("All elements: ");
                    foreach (LibraryItem item in libraryItems)
                    {
                        Console.WriteLine(item.DisplayInfo());
                        Console.WriteLine("----------");
                    }
                    break;  
                case "2":
                    Console.WriteLine("Available elements: ");
                    foreach (LibraryItem item in libraryItems)
                    {
                        if(item != null)
                        Console.WriteLine(item.DisplayInfo());
                        Console.WriteLine("----------");
                    }
                    break;  
                case "5":
                    Console.WriteLine("Exit the program");
                    exit = true;
                    break;
                default: 
                    Console.WriteLine("Please choose an option: ");
                    break;
            }
        }
        
        /*Book book1 = new Book("Green Mile", "Stephen King", 1988, 305);
        book1.DisplayInfo();
        book1.Borrow("Serhii");
        book1.Borrow("James");
        book1.Return();
        book1.Borrow("James");

        Journal journal = new Journal("Times", "John L", 2022, "2025 jan");
        journal.DisplayInfo();
        journal.Borrow("John");
        journal.Borrow("Jane");
        journal.Return();
        journal.Borrow("Jane");*/
    
        // EBook eBook = new EBook("Adventure", "Sara", 2024, "pdf");
        // eBook.DisplayInfo();
    }
}