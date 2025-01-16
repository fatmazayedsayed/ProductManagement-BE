using ProductManagement.Common.Enum;
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
        public decimal Price { get;   set; }
        public ProductStatus Status { get;   set; }
        public int StockQuantity { get;   set; }
        public string ImageUrl { get;   set; }
    }
}
