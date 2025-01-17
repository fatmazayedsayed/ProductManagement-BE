using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Common.DTO.Common;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class GetCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GetAllResult<CategoryRecord>> HandleAsync(GetCategoryRequest req, CancellationToken ct)
        {
            try
            {
                var records = await _unitOfWork.Category.GetAll(req, ct);
 
                return new GetAllResult<CategoryRecord> { Records = records.Skip(req.PageNumber).Take(req.PageSize), Count = records.Count() };
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
