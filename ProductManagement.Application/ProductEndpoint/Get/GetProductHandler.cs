using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Common.DTO.Common;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GetAllResult<ProductRecord>> HandleAsync(GetProductRequest req, CancellationToken ct)
        {
            try
            {
                var records = await _unitOfWork.Product.GetAll(req, ct);

                return new GetAllResult<ProductRecord> { Records = records.Skip(req.PageNumber).Take(req.PageSize), Count = records.Count() };
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
