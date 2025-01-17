using ProductManagement.Common.DTO.LookUps;
using ProductManagement.Domain.Models;
using ProductManagement.Common.DTO.ProductDTO;
using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.ProductEndpoint.CommonDTO;

namespace ProductManagement.Application.Abstractions.DataAbstractions
{
    public interface IProductRepository
    {
        Task<Product?> Create(Product request);
        Task<bool> IsFound(ProductDto request);
        Task<Product?> Update(Product request);
        Task<bool> Delete(Guid id);
        Task<Product?> GetById(Guid id);

        Task<IEnumerable<ProductRecord>> GetAll(GetProductRequest req, CancellationToken cancellationToken);
        Task<IEnumerable<LookUpDTO>> ProductsLookUp(CancellationToken cancellationToken);
        Task<int> CountAsync();
    }
}
