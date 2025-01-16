using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductRecords;

namespace ProductManagement.Application.ProductEndpoint.Update
{
    public class UpdateProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductRecord?> HandleAsync(UpdateProductRequest req, CancellationToken ct)
        {
            try
            {
                var ProductEntity = req.ToProduct();
                var createdProduct = await _unitOfWork.Product.Update(ProductEntity);
                await _unitOfWork.SaveChangesAsync(ct);

                var dto = createdProduct.ToProductResult();
                return dto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
