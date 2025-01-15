using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CategoryRecords;
using ProductManagement.Domain.Models;
using System.Threading;

namespace ProductManagement.API.CategoryEndpoint.Create
{
    public class GetCategoryHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CategoryRecord>> HandleAsync(GetCategoryRequest req, CancellationToken ct)
        {
            try
            {
                var records = await _unitOfWork.Category.GetAll(req, ct);
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
