using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Domain.Models;
using Abp.Collections.Extensions;
using ProductManagement.Common.DTO.LookUps;
using ProductManagement.Common.DTO.ProductDTO;
using ProductManagement.API.ProductEndpoint.Create;
using Abp.Linq.Extensions;
using ProductManagement.Application.ProductEndpoint.CommonDTO;

namespace ProductManagement.Infrastructure.Repositories
{
    public class ProductRepository(ProductManagementDbContext ctx) : IProductRepository
    {
        public async Task<Product?> Create(Product request)
        {
            var res = await ctx.Products.AddAsync(request);
            return res.Entity;
        }
        public async Task<bool> IsFound(ProductDto request)
        {
            var res = ctx.Products.Any(e => e.Name == request.Name && e.Id != request.Id);
            return res;
        }


        public async Task<IEnumerable<ProductRecord>> GetAll(GetProductRequest req, CancellationToken cancellationToken)
        {
            return await ctx.Products
                .Include(e => e.Category)
                .AsNoTracking()

                    .WhereIf(!string.IsNullOrWhiteSpace(req.SearchString),
                    e =>
                    e.Name.Contains(req.SearchString, StringComparison.OrdinalIgnoreCase)
                    )
                     .WhereIf(req.CategoryId != Guid.Empty && req.CategoryId != null,
                    e =>
                    e.CategoryId == req.CategoryId
                    )
                .Select(Product => new ProductRecord
                {
                    Id = Product.Id,
                    Name = Product.Name,
                    Description = Product.Description,
                    CategoryId = Product.CategoryId,
                    CategoryName = Product.Category.Name
                }).ToListAsync();
        }


        public async Task<IEnumerable<LookUpDTO>> ProductsLookUp(CancellationToken cancellationToken)
        {
            return await ctx.Products.AsNoTracking()
                .Select(Product => new LookUpDTO
                {
                    Id = Product.Id,
                    Name = Product.Name
                }).ToListAsync();
        }
        public async Task<Product?> GetById(Guid id)
        {
            return await ctx.Products
                .Include (e => e.Category)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Product?> Update(Product request)
        {
            var row = await ctx.Products.FirstOrDefaultAsync(e => e.Id == request.Id);
            row.Name = request.Name;
            row.Description = request.Description;
            row.CategoryId = request.CategoryId;
            return row;
        }

        public async Task<bool> Delete(Guid Id)
        {
            var row = await ctx.Products.FirstOrDefaultAsync(e => e.Id == Id);
            row.IsDeleted = true;
            return true;
        }

        public async Task<int> CountAsync()
        {
            return   ctx.Products.AsNoTracking().Count();
        }


    }
}
