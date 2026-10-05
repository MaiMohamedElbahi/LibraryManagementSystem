using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.BorrowingDTO
{
    public class UpdateBorrowingDTO
    {
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    }
}
