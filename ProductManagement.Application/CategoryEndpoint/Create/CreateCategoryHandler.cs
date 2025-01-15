using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Application.CategoryRecords;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class CreateCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryRecord?> HandleAsync(CreateCategoryRequest req, CancellationToken ct)
        {
            try
            {
                var categoryEntity = req.ToCategory();
                var createdCategory = await _unitOfWork.Category.Create(categoryEntity);
                await _unitOfWork.SaveChangesAsync(ct);

                var dto = CategoryMapping.ToCategoryResult(createdCategory);
                return dto; // Return the mapped CategoryRecord on success
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
