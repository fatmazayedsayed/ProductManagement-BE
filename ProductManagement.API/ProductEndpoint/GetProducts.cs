using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.ProductEndpoint.Create;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
    [ApiExplorerSettings(GroupName = "Product")]
    [Authorize]
    public class GetProducts : Endpoint<GetProductRequest>
    {
        private readonly GetProductHandler _handler;

        public GetProducts(GetProductHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/Products/GetProduct");
         }

        public override async Task HandleAsync(GetProductRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null or an empty collection
            if (result == null || !result.Any())
            {
                await SendAsync(new { Message = "No Products found." }, statusCode: 404, cancellation: ct); // Returning 404 if no Products found
                return;
            }

            // Send success response
            await SendAsync(new
            {
                Message = "Products retrieved successfully.",
                Data = result
            }, statusCode: 200, cancellation: ct);
        }


    }

}
