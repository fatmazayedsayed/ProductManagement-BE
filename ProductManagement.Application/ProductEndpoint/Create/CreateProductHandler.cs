using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductRecords;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class CreateProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductRecord?> HandleAsync(CreateProductRequest req, CancellationToken ct)
        {
            try
            {
                var ProductEntity = req.ToProduct();
                var createdProduct = await _unitOfWork.Product.Create(ProductEntity);
                await _unitOfWork.SaveChangesAsync(ct);

                var dto = ProductMapping.ToProductResult(createdProduct);
                return dto; // Return the mapped ProductRecord on success
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
