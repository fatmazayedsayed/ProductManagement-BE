using FastEndpoints;
using ProductManagement.Application.UserEndpoint;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.AuthenticationEndPoint
{
    public class UserLogin : Endpoint<Login>
    {
        private readonly LoginHandler _handler;

        public UserLogin(LoginHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.POST);
            Routes("/api/Auth");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Login req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null (indicating failure)
            if (result == null)
            {
                await SendAsync(new { isSuccess = false, Message = "login failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // Send success response with status code 200
            await SendAsync(new
            {
                isSuccess = true,
                Message = "Login  successfully",
                Data = result, // Assuming result is a CategoryRecord or similar
                userType= result.UserType,
            }, statusCode: 200, cancellation: ct);
        }

    }

}
