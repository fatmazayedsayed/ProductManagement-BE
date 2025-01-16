using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Application.ProductEndpoint.Update
{
    public class UpdateProductRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Description { get; set; }

        public Guid CategoryId { get; set; }
    }
}
