using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.REPOs.Interfaces
{
    public interface IUnitOfWork 
    {
        IGenericRepo<Book> Books { get; }
        IGenericRepo<Category> Categories { get; }
        IGenericRepo<Member> Members { get; }
        IGenericRepo<Borrowing> Borrowings { get; }

        void Save();
    }
}
