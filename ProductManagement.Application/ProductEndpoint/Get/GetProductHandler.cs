using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.ProductEndpoint.CommonDTO;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProductRecord>> HandleAsync(GetProductRequest req, CancellationToken ct)
        {
            try
            {
                var records = await _unitOfWork.Product.GetAll(req, ct);
                await _unitOfWork.SaveChangesAsync(ct);

                return records;
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
