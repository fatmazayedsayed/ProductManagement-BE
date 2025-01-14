

namespace ProductManagement.Common.DTO.GroupDTO
{
    public record CategoryListDTO
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
         public string? Description { get; init; } 
    }
}