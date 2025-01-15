using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.Delete;

namespace ProductManagement.Application.CategoryEndpoint.Update
{
    public class DeleteCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> HandleAsync(DeleteCategoryRequest req, CancellationToken ct)
        {
            var category = await _unitOfWork.Category.GetById(req.CategoryId);

            if (category == null)
            {
                return false; // Category not found
            }

            _unitOfWork.Category.Delete(req.CategoryId);
            await _unitOfWork.SaveChangesAsync(ct);

            return true; // Deletion successful
        }
    }
}
