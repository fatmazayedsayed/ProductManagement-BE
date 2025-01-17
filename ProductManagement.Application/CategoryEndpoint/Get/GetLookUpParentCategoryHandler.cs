using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Common.DTO.LookUps;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class GetLookUpParentCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetLookUpParentCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<LookUpDTO>> HandleAsync( CancellationToken ct)
        {
            try
            {
                var records = await _unitOfWork.Category.ParentCategoriesLookUp(ct);

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
