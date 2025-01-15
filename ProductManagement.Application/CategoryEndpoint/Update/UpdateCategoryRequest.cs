using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Application.CategoryEndpoint.Update
{
    public class UpdateCategoryRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Description { get; set; }

        public Guid? ParentCategoryId { get; set; }
    }
}
