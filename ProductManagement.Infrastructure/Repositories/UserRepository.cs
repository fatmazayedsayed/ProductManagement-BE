using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.DTOMapping;
using ProductManagement.Application.UserEndpoint;
using ProductManagement.Common.DTO.Auth;
using ProductManagement.Domain.Models;

namespace ProductManagement.Infrastructure.Repositories
{
    public class UserRepository(ProductManagementDbContext context) : IUserRepository
    {
        public async Task<User?> GetByUserNameOrEmailAsync(Login request, CancellationToken cancellationToken)
        {
            var result = await context.Users.Where(e => e.Email == request.UserName || e.UserName==request.UserName)
                  .FirstOrDefaultAsync(cancellationToken);
            return result;
        }


        public async Task<UserDetailsDTO?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await context.Users.Where(a => a.Id == id).FirstOrDefaultAsync(cancellationToken);
            return UserMapping.ToUserDetails(result);
        }
        public async Task<User?> GetUserByMailAsync(String Email, CancellationToken cancellationToken)
        {
            return await context.Users.Where(a => a.Email == Email).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<User?> FindUserByIdAsync(Guid id)
        {
            return await context.Users.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsFound(string Email, Guid Id)
        {
            var res = context.Users.Any(e => e.Email.ToLower() == Email.ToLower() && e.Id != Id);
            return res;
        }
        public async Task<User?> GetUserProfileAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Users.Where(u => u.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

    }

}

