using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.CategoryDTO
{
    public class UpdateCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
