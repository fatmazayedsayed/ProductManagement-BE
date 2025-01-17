using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using ProductManagement.API.CategoryEndpoint.Create;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.CategoryEndpoint
{
    [Authorize]
    public class GetLookUpCategories : EndpointWithoutRequest
    {
        private readonly GetLookUpCategoryHandler _handler;

        public GetLookUpCategories(GetLookUpCategoryHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/categories/GetLookUpCategories");
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            // Call the handler to retrieve categories
            var result = await _handler.HandleAsync(ct);

            // Check if the result is null or empty
            if (result == null || !result.Any())
            {
                await SendAsync(new { Message = "No categories found." }, statusCode: 404, cancellation: ct);
                return;
            }

            // Send success response with data
            await SendAsync(new
            {
                Message = "Categories retrieved successfully.",
                Data = result
            }, statusCode: 200, cancellation: ct);
        }
    }

}
