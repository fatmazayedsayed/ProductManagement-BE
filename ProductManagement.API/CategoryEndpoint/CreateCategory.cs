using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using ProductManagement.API.CategoryEndpoint.Create;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.CategoryEndpoint
{
    [Authorize]
    public class CreateCategory : Endpoint<CreateCategoryRequest>
    {
        private readonly CreateCategoryHandler _handler;

        public CreateCategory(CreateCategoryHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.POST);
            Routes("/api/categories/create");
         }

        public override async Task HandleAsync(CreateCategoryRequest req, CancellationToken ct)
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
