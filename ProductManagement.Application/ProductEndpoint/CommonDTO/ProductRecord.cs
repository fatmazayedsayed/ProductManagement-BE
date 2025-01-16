using ProductManagement.Common.Enum;

namespace ProductManagement.Application.ProductEndpoint.CommonDTO
{
    public class ProductRecord
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }
    }
}
