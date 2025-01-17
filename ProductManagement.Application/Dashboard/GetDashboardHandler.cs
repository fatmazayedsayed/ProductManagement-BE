using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.CommonDTO;
using ProductManagement.Application.ProductEndpoint.CommonDTO;
using ProductManagement.Application.ProductRecords;

namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetDashboardHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetDashboardHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DashboardMetrics> HandleAsync( CancellationToken ct)
        {
            try
            {
                var totalProducts = await _unitOfWork.Product.CountAsync();
                var totalCategories = await _unitOfWork.Category.CountAsync();

                var productsPerCategory = await  _unitOfWork.Category.GetProductsPerCategoryAsync();

                return new DashboardMetrics
                {
                    TotalProducts = totalProducts,
                    TotalCategories = totalCategories,
                    ProductsPerCategory = productsPerCategory
                };
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}
