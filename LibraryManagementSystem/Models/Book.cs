using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    [Index(nameof(ISBN), IsUnique = true)]
    [DefaultValue(true)]

    public class Book
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;

        public int CategoryId  { get; set; }
        public Category Category { get; set; }

        public List<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

    }
}
