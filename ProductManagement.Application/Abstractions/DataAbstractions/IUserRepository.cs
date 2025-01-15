using ProductManagement.Application.UserEndpoint;
using ProductManagement.Common.DTO.Auth;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.Abstractions.DataAbstractions
{
    public interface IUserRepository
    {
        Task<UserDetailsDTO?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<User?> FindUserByIdAsync(Guid id);
        Task<User?> GetByEmailAsync(Login request, CancellationToken cancellationToken);
        Task<bool> IsFound(string Email, Guid Id);
        Task<User?> GetUserByMailAsync(string Email, CancellationToken cancellationToken);
        Task<User?> GetUserProfileAsync(Guid id, CancellationToken cancellationToken);
    }
}
