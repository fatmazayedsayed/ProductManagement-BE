

namespace ProductManagement.Common.DTO.GroupDTO
{
    public record ProductListDTO
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
         public string? Description { get; init; } 
    }
}