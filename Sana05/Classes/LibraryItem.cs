namespace Sana05.Classes;

abstract public class LibraryItem
{
    protected string Title { get; set; }
    protected string Author { get; set; }
    protected int Year { get; set; }

    public LibraryItem(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    abstract public void DisplayInfo();
}