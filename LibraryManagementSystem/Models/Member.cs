using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Member
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public List<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
