namespace ProductManagement.Application.ProductEndpoint.CommonDTO
{
    public class ProductRecord
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Guid CategoryId { get; set; }
    }
}
