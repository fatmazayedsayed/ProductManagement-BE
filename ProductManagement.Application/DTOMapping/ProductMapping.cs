using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductEndpoint.Update;
using ProductManagement.Common.DTO.GroupDTO;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.ProductRecords
{

    public record ProductGetAllResult
    {
        public IEnumerable<ProductListDTO> Products { get; set; }
        public int Count { get; set; }
    }

    public static class ProductMapping
    {
        public static Product ToProduct(this CreateProductRequest dto)
        {
            return new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                Status = dto.Status,
                StockQuantity = dto.StockQuantity,
                ImageUrl = dto.ImageUrl,
                CategoryId = dto.CategoryId,

            };
        }

        public static ProductRecord ToProductResult(this Product dto)
        {
            return new ProductRecord
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                CategoryId = dto.CategoryId,
                Price = dto.Price,
                Status = dto.Status,
                StockQuantity = dto.StockQuantity,
                ImageUrl = dto.ImageUrl,
            };
        }



        public static Product ToProduct(this UpdateProductRequest dto)
        {
            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                CategoryId = dto.CategoryId,
                Price = dto.Price,
                Status = dto.Status,
                StockQuantity = dto.StockQuantity,
                ImageUrl = dto.ImageUrl,

            };
        }
        public static ProductGetAllResult ToProductGetAllResult(this IEnumerable<ProductListDTO> products, int count)
        {
            var res = new ProductGetAllResult
            {
                Products = products.ToList(),
                Count = count
            };
            return res;
        }
    }
}