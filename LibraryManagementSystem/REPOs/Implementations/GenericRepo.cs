using LibraryManagementSystem.Data;
using LibraryManagementSystem.REPOs.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.REPOs.Implementations
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepo(AppDbContext context)
        {
            _context = context;
            _db =  _context.Set<T>();
        }
        public void Create(T item)
        {
            _db.Add(item);
        }

        public void Delete(int id)
        {
            _db.Remove(_db.Find(id));
        }

        public List<T> GetAll()
        {
            return _db.ToList();
        }

        public T GetById(int id)
        {
            return _db.Find(id);
        }

        public void Update(T item)
        {
            _db.Update(item);
        }
    }
}
