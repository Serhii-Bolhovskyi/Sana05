using Sana05.Interfaces;

namespace Sana05.Classes;

public class Book : LibraryItem, IBorrowable
{
    protected int PageCount { get; set; }
    private BorrowInfo? borrowInfo;
    private bool _isBorrowed;

    public Book(string title, string author, int year, int pageCount) : base(title, author, year)
    {
        PageCount = pageCount;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}\nAuthor: {Author}\nYear: {Year}\nPage count: {PageCount}");
    }

    public bool IsBorrowed
    {
        get => _isBorrowed;
        set => _isBorrowed = value;
    }

    public void Borrow(string borrower)
    {
        if (IsBorrowed)
        {
            
        }
        throw new NotImplementedException();
    }

    public void Return()
    {
        throw new NotImplementedException();
    }
}