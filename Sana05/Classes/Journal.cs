namespace Sana05.Classes;

public class Journal : LibraryItem
{
    protected string Issue { get; set; }

    public Journal(string title, string author, int year, string issue) : base(title, author, year)
    {
        Issue = issue;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}\nAuthor: {Author}\nYear: {Year}\nIssue: {Issue}");
    }
}