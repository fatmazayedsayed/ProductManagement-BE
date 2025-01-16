using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.ProductEndpoint.Delete;

namespace ProductManagement.Application.ProductEndpoint.Update
{
    public class DeleteProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> HandleAsync(DeleteProductRequest req, CancellationToken ct)
        {
            var Product = await _unitOfWork.Product.GetById(req.ProductId);

            if (Product == null)
            {
                return false; // Product not found
            }

            _unitOfWork.Product.Delete(req.ProductId);
            await _unitOfWork.SaveChangesAsync(ct);

            return true; // Deletion successful
        }
    }
}
