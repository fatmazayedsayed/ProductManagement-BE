using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Application.CategoryRecords;
using ProductManagement.Domain.Models;
using System.Threading;

namespace ProductManagement.Application.CategoryEndpoint.Update
{
    public class UpdateCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryRecord?> HandleAsync(UpdateCategoryRequest req, CancellationToken ct)
        {
            try
            {
                var categoryEntity = req.ToCategory();
                var createdCategory = await _unitOfWork.Category.Update(categoryEntity);
                await _unitOfWork.SaveChangesAsync(ct);

                var dto = createdCategory.ToCategoryResult();
                return dto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
