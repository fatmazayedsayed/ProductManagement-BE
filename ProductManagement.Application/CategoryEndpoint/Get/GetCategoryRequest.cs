using ProductManagement.Common.DTO.Common;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public record GetCategoryRequest : BaseListingInput
    {
        public Guid? ParentCategoryId { get; set; }
    }
}
