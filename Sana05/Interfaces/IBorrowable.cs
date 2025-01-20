namespace Sana05.Interfaces;

public interface IBorrowable 
{
    bool IsBorrowed { get; }

    void Borrow(string borrower);
    void Return();
}