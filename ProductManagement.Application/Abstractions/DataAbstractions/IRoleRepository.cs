 using ProductManagement.Common.DTO.Common;
using ProductManagement.Common.DTO.LookUps;
 using ProductManagement.Domain.Models;
using ProductManagement.Common.DTO.CategoryDTO;

namespace ProductManagement.Application.Abstractions.DataAbstractions
{
    public interface ICategoryRepository
    {
        Task<Category?> Create(Category request);
        Task<bool> IsFound(CategoryDto request);
         Task<Category?> Update(CategoryDto request);
         Task<Category?> GetById(Guid id);
        Task<IEnumerable<LookUpDTO>> CategoriesLookUp(CancellationToken cancellationToken);
    }
}
