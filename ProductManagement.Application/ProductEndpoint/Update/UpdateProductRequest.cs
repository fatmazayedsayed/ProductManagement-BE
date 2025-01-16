using ProductManagement.Common.Enum;
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
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
    }
}
