using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.MemberDTO
{
    public class UpdateMemberDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
