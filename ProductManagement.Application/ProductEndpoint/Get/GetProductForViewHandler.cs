using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CommonDTO;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductRecords;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetProductForViewHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductForViewHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductRecord> HandleAsync(ItemRequest req, CancellationToken ct)
        {
            try
            {
                var record = await _unitOfWork.Product.GetById(req.ItemId);
 
                return record.ToProductResult();
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
