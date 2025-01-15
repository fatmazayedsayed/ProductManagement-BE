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
                var user = await _unitOfWork.Authentication.GetByEmailAsync(request, ct);

                var result = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);
                var isEqualPassword = result.Equals(PasswordVerificationResult.Success);

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


