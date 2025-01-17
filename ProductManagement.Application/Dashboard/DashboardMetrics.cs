namespace ProductManagement.Application.ProductEndpoint.CommonDTO
{
    public record DashboardMetrics
    {
        public int TotalProducts { get; set; }
        public int TotalCategories { get; set; }
        public IEnumerable<ProductsPerCategory> ProductsPerCategory { get; set; }  
    }

    public record ProductsPerCategory
    {
        public string CategoryName { get; set; } = string.Empty;
        public int ProductCount { get; set; }
    }

}
