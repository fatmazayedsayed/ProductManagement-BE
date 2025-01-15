using ProductManagement.Common.DTO.Auth;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.DTOMapping
{
    public static class UserMapping
    {
        public static UserDetailsDTO ToUserDetails(this User user)
        {
            var result = new UserDetailsDTO
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.UserName,
            };
            return result;
        }

    }
}
