using Sana05.Interfaces;

namespace Sana05.Classes;

public class Book : LibraryItem, IBorrowable
{
    protected int PageCount { get; set; }
    
    private BorrowInfo? borrowInfo; //Використовується, щоб перевіряти, чи книга позичена, і зберігати дані позичальника.

    public Book(string title, string author, int year, int pageCount) : base(title, author, year)
    {
        PageCount = pageCount;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}\nAuthor: {Author}\nYear: {Year}\nPage count: {PageCount}");
    }

    public bool IsBorrowed => borrowInfo != null;

    public void Borrow(string borrower)
    {
        if (IsBorrowed)
        {
            Console.WriteLine($"The book is already borrowed by {borrowInfo!.BorrowerName} on {borrowInfo.BorrowDate}.");
            return;
        }
        borrowInfo = new BorrowInfo(borrower, DateTime.Now.DayOfWeek);
        Console.WriteLine($"The book '{Title}', {Author} has been borrowed by {borrower} on {DateTime.Now.DayOfWeek}.");
    }
    public void Return()
    {
        if (!IsBorrowed)
        {
            Console.WriteLine($"The book '{Title}' is not currently borrowed.");
            return;
        }

        Console.WriteLine($"The book '{Title}' borrowed by {borrowInfo!.BorrowerName} on {borrowInfo.BorrowDate} has been returned.");
        borrowInfo = null;
    }
}