namespace Sana05.Classes;

public class Book : LibraryItem
{
    protected int PageCount { get; set; }

    public Book(string title, string author, int year, int pageCount) : base(title, author, year)
    {
        PageCount = pageCount;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}\nAuthor: {Author}\nYear: {Year}\nPage count: {PageCount}");
    }
}