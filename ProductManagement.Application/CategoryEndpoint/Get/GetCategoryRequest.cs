using System.ComponentModel.DataAnnotations;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class GetCategoryRequest
    {
       
        public string Name { get; set; }  

        public Guid? ParentCategoryId { get; set; }
    }
}
