namespace Sana05.Classes;

public class EBook : LibraryItem
{
    protected string FileFormat { get; set; }

    public EBook(string title, string author, int year, string fileFormat) : base(title, author, year)
    {
        FileFormat = fileFormat;
    }

    public override string DisplayInfo()
    {
        return ($"EBook: {Title}\nAuthor: {Author}\nYear: {Year}\nFile Format: { FileFormat}");
    }
}