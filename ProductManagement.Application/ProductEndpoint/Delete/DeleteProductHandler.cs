using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CommonDTO;
 
namespace ProductManagement.Application.ProductEndpoint.Update
{
    public class DeleteProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> HandleAsync(ItemRequest req, CancellationToken ct)
        {
            var Product = await _unitOfWork.Product.GetById(req.ItemId);

            if (Product == null)
            {
                return false; // Product not found
            }

            _unitOfWork.Product.Delete(req.ItemId);
            await _unitOfWork.SaveChangesAsync(ct);

            return true; // Deletion successful
        }
    }
}
