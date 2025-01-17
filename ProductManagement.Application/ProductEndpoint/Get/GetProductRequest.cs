using ProductManagement.Common.DTO.Common;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public record GetProductRequest : BaseListingInput
    {
       public Guid? CategoryId { get; set; }
    }
}
