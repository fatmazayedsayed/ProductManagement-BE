using Microsoft.AspNetCore.Identity;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Application.Identity;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.UserEndpoint
{
    public class LoginHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly TokenAuthentication _authenticationHandler;

        public LoginHandler(IUnitOfWork unitOfWork, TokenAuthentication authenticationHandler, IPasswordHasher<User> passwordHasher)
        {
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
            _authenticationHandler = authenticationHandler;
        }

        public async Task<LoginResult?> HandleAsync(Login request, CancellationToken ct)
        {
            try
            {
                var user = await _unitOfWork.Authentication.GetByUserNameOrEmailAsync(request, ct);

               var isEqualPassword = string.Equals(user.Password, CryptoUtils.PBKDF2Hash(request.Password));

                if (isEqualPassword)
                {
                    return new LoginResult
                    {
                        IsSuccess = true,
                        Token = _authenticationHandler.GenerateJwtToken(new ActiveContext
                        {
                            UserId = user.Id,
                            UserName = user.UserName,
                            UserType = user.UserType
                        }),
                        Id = user.Id,
                        UserType = user.UserType

                    };
                }
                else
                {
                    return null;

                }
            }
            catch (Exception ex)
            {
                // Log the error as needed and return null to indicate failure
                return null;
            }
        }

    }
}


