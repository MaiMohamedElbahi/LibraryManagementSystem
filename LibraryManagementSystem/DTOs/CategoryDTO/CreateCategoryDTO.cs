using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs.CategoryDTO
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
