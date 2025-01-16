using System.ComponentModel.DataAnnotations;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class CreateProductRequest
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Description { get; set; }

        public Guid CategoryId { get; set; }
    }
}
