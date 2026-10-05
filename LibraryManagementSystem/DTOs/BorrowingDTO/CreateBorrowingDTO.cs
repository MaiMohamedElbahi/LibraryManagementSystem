using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.BorrowingDTO
{
    public class CreateBorrowingDTO
    {
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    }
}
