using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasMany(e => e.Borrowings).WithOne(
                e => e.Book).HasForeignKey(e => e.Id);
            modelBuilder.Entity<Member>().HasMany(e => e.Borrowings).WithOne(
                e => e.Member).HasForeignKey(e => e.Id);
            modelBuilder.Entity<Category>().HasMany(e => e.Books).WithOne(
                e => e.Category).HasForeignKey(e => e.Id);


            // 1. Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", Description = "Literature in the form of prose, especially novels." },
                new Category { Id = 2, Name = "Science & Tech", Description = "Books covering physics, space, coding, and innovations." },
                new Category { Id = 3, Name = "History", Description = "Biographies, historical events, and ancient civilizations." }
            );

            // 2. Seed Books (Linked to Category via CategoryId)
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    ISBN = "9780743273565",
                    Price = 299.99m,
                    IsAvailable = true,
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Clean Code",
                    Author = "Robert C. Martin",
                    ISBN = "9780132350884",
                    Price = 850.00m,
                    IsAvailable = true,
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Sapiens: A Brief History of Humankind",
                    Author = "Yuval Noah Harari",
                    ISBN = "9780062316097",
                    Price = 450.50m,
                    IsAvailable = false, // Currently borrowed
                    CategoryId = 3
                }
            );

            // 3. Seed Members
            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, FullName = "Ahmed Aly", Email = "ahmed.aly@example.com", Phone = "01012345678" },
                new Member { Id = 2, FullName = "Sarah Mansour", Email = "sarah.m@example.com", Phone = "01287654321" },
                new Member { Id = 3, FullName = "Omar Tarek", Email = "omar.tarek@example.com", Phone = "01599998888" }
            );

            // 4. Seed Borrowing (Linked to MemberId and BookId to avoid Foreign Key errors)
            modelBuilder.Entity<Borrowing>().HasData(
                new Borrowing
                {
                    Id = 1,
                    BorrowDate = new DateTime(2026, 9, 1),
                    ReturnDate = new DateTime(2026, 9, 15), // Completed return
                    MemberId = 1,
                    BookId = 1
                },
                new Borrowing
                {
                    Id = 2,
                    BorrowDate = new DateTime(2026, 9, 20),
                    ReturnDate = null, // Still active/Not returned yet
                    MemberId = 2,
                    BookId = 3
                }
            );
        }
    }
}
