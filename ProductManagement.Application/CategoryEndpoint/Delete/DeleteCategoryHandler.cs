using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CommonDTO;

namespace ProductManagement.Application.CategoryEndpoint.Update
{
    public class DeleteCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> HandleAsync(ItemRequest req, CancellationToken ct)
        {
            var category = await _unitOfWork.Category.GetById(req.ItemId);

            if (category == null)
            {
                return false; // Category not found
            }

            _unitOfWork.Category.Delete(req.ItemId);
            await _unitOfWork.SaveChangesAsync(ct);

            return true; // Deletion successful
        }
    }
}
