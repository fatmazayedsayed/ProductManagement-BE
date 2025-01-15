using FastEndpoints;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.CategoryEndpoint.Update;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.CategoryEndpoint
{
    [ApiExplorerSettings(GroupName = "Category")]
    public class UpdateCategory : Endpoint<UpdateCategoryRequest>
    {
        private readonly UpdateCategoryHandler _handler;

        public UpdateCategory(UpdateCategoryHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.PUT);
            Routes("/api/categories");
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateCategoryRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null (indicating failure)
            if (result == null)
            {
                await SendAsync(new { Message = "Category creation failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // Send success response with status code 200
            await SendAsync(new
            {
                Message = "Category created successfully",
                Data = result // Assuming result is a CategoryRecord or similar
            }, statusCode: 200, cancellation: ct);
        }

    }

}
