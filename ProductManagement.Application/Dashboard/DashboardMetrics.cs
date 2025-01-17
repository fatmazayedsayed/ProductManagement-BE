using ProductManagement.Common.Enum;

namespace ProductManagement.Application.ProductEndpoint.CommonDTO
{
    public class DashboardMetrics
    {
        public int TotalProducts { get; set; }
        public int TotalCategories { get; set; }
        public IEnumerable<ProductsPerCategory> ProductsPerCategory { get; set; }  
    }

    public class ProductsPerCategory
    {
        public string CategoryName { get; set; } = string.Empty;
        public int ProductCount { get; set; }
    }

}
