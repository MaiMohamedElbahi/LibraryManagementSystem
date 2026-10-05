using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.REPOs.Interfaces;

namespace LibraryManagementSystem.REPOs.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
       public IGenericRepo<Book> Books { get; set; }
        public IGenericRepo<Category> Categories { get; set; }
        public IGenericRepo<Member> Members { get; set; }
        public IGenericRepo<Borrowing> Borrowings { get; set; }
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Books = new GenericRepo<Book>(_context);
            Categories = new GenericRepo<Category>(_context);
            Members = new GenericRepo<Member>(_context);
            Borrowings = new GenericRepo<Borrowing>(_context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
