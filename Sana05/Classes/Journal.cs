using Sana05.Interfaces;

namespace Sana05.Classes;

public class Journal : LibraryItem, IBorrowable
{
    protected string Issue { get; set; }
    private BorrowInfo? borrowInfo;

    public Journal(string title, string author, int year, string issue) : base(title, author, year)
    {
        Issue = issue;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Journal: {Title}\nAuthor: {Author}\nYear: {Year}\nIssue: {Issue}");
    }
    
    public bool IsBorrowed => borrowInfo != null;

    public void Borrow(string borrower)
    {
        if (IsBorrowed)
        {
            Console.WriteLine($"The Journal is already borrowed by {borrowInfo!.BorrowerName} on {borrowInfo.BorrowDate}.");
            return;
        }
        borrowInfo = new BorrowInfo(borrower, DateTime.Now.DayOfWeek);
        Console.WriteLine($"The Journal '{Title}', Issue: {Issue} has been borrowed by {borrower} on {DateTime.Now.DayOfWeek}.");
    }
    public void Return()
    {
        if (!IsBorrowed)
        {
            Console.WriteLine($"The Journal '{Title}', Issue: {Issue}  is not currently borrowed.");
            return;
        }

        Console.WriteLine($"The Journal '{Title}', Issue: {Issue} borrowed by {borrowInfo!.BorrowerName} on {borrowInfo.BorrowDate} has been returned.");
        borrowInfo = null;
    }
}