namespace ProductManagement.Application.UserEndpoint
{
    public record LoginResult
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        
        public bool IsSuccess { get; set; }
    }
}
