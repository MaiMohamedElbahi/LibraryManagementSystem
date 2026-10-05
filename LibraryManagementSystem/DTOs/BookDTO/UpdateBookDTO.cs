using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.BookDTO
{
    public class UpdateBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int CategoryId { get; set; }
    }
}
