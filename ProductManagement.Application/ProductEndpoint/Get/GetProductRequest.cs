namespace ProductManagement.API.ProductEndpoint.Create
{
    public class GetProductRequest
    {
       
        public string Name { get; set; }  

        public Guid? CategoryId { get; set; }
    }
}
