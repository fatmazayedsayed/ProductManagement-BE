using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Application.CategoryEndpoint.Update;
using ProductManagement.Common.DTO.GroupDTO;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.CategoryRecords
{

    public record CategoryGetAllResult
    {
        public IEnumerable<CategoryListDTO> Categories { get; set; }
        public int Count { get; set; }
    }

    public static class CategoryMapping
    {
        public static Category ToCategory(this CreateCategoryRequest dto)
        {
            return new Category
            {
                Name = dto.Name,
                Description = dto.Description,
                ParentCategoryId = dto.ParentCategoryId
            };
        }

        public static CategoryRecord ToCategoryResult(this Category dto)
        {
            return new CategoryRecord
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                ParentCategoryId = dto.ParentCategoryId
            };
        }



        public static Category ToCategory(this UpdateCategoryRequest dto)
        {
            return new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                ParentCategoryId = dto.ParentCategoryId
            };
        }
        public static CategoryGetAllResult ToCategoryGetAllResult(this IEnumerable<CategoryListDTO> Categories, int count)
        {
            var res = new CategoryGetAllResult
            {
                Categories = Categories.ToList(),
                Count = count
            };
            return res;
        }
    }
}