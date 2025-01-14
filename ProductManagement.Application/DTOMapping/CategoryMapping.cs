using ProductManagement.Common.DTO.GroupDTO;

namespace ProductManagement.Application.CategoryRecords
{
    public record CategoryResultDto
    {
        public Guid Id;
        public string Name;
        public string Code;
        public string Description;
    }
    public record CategoryGetAllResult
    {
        public IEnumerable<CategoryListDTO>Categories { get; set; }
        public int Count { get; set; }
    }

    public static class CategoryMapping
    {
        public static CategoryResultDto ToCategoryResult(this Domain.Models.Category Category)
        {
            return new CategoryResultDto
            {
                Id = Category.Id,
                Name = Category.Name,
                 Description = Category.Description
            };
        }

        public static CategoryGetAllResult ToCategoryGetAllResult(this IEnumerable<CategoryListDTO>Categories, int count)
        {
            var res = new CategoryGetAllResult
            {
               Categories =Categories.ToList(),
                Count = count
            };
            return res;
        }
    }
}