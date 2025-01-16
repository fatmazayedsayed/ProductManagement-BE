using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Application.CategoryRecords;
using ProductManagement.Application.CommonDTO;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductRecords;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetCategoryForViewHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoryForViewHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryRecord> HandleAsync(ItemRequest req, CancellationToken ct)
        {
            try
            {
                var record = await _unitOfWork.Category.GetById(req.ItemId);
 
                return record.ToCategoryResult();
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
