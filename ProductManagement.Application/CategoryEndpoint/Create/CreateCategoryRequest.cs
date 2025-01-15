using System.ComponentModel.DataAnnotations;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class CreateCategoryRequest
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Description { get; set; }

        public Guid? ParentCategoryId { get; set; }
    }
}
