using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Abstractions.DataAbstractions; 
using ProductManagement.Domain.Models;
using Abp.Collections.Extensions;
 using ProductManagement.Common.DTO.LookUps;
using ProductManagement.Common.DTO.CategoryDTO;

namespace ProductManagement.Infrastructure.Repositories
{
    public class CategoryRepository(ProductManagementDbContext ctx) : ICategoryRepository
    {
        public async Task<Category?> Create(Category request)
        {
            var res = await ctx.Categories.AddAsync(request);
            return res.Entity;
        }
        public async Task<bool> IsFound(CategoryDto request)
        {
            var res = ctx.Categories.Any(e => e.Name == request.Name && e.Id != request.Id);
            return res;
        }
        
        
        public async Task<IEnumerable<LookUpDTO>> CategoriesLookUp(CancellationToken cancellationToken)
        {
            return await ctx.Categories.AsNoTracking()
                .Select(Category => new LookUpDTO
                {
                    Id = Category.Id,
                    Name = Category.Name
                }).ToListAsync();
        }
         public async Task<Category?> GetById(Guid id)
        {
            return await ctx.Categories.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Category?> Update(CategoryDto request)
        {
            var row = await ctx.Categories.FirstOrDefaultAsync(e => e.Id == request.Id);
            row.Name = request.Name;
             return row;
        }


    }
}
