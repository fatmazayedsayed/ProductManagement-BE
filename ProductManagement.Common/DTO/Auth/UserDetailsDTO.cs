namespace ProductManagement.Common.DTO.Auth
{
    public record UserDetailsDTO
    {
        public Guid Id { get; init; }

        public string Email { get; init; }

        public string Username { get; init; }

    }

}
