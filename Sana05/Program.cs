namespace Sana05;
using Sana05.Classes;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("San Antonio", "Mario", 1988, 305);
        book1.DisplayInfo();
        book1.Borrow("Serhii");
        book1.Return();

        Journal journal = new Journal("Arrow", "John", 2022, "e24sd44");
        journal.Borrow("John");
        journal.Borrow("Jane");
        journal.Return();
        journal.Borrow("Jane");
        // journal.DisplayInfo();
        //
        // EBook eBook = new EBook("Adventure", "Sara", 2024, "pdf");
        // eBook.DisplayInfo();
    }
}