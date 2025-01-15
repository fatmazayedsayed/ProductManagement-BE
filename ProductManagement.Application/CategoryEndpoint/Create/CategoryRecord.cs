using System.ComponentModel.DataAnnotations;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class CategoryRecord
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; }

        public Guid? ParentCategoryId { get; set; }
    }
}
