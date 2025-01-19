namespace Sana05.Interfaces;

public interface IBorrowable
{
    bool IsBorrowed { get; set; }

    void Borrow(string borrower);
    void Return();
}