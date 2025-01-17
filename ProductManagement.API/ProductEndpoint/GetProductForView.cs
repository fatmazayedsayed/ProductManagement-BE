using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.CommonDTO;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
     [Authorize]
    public class GetProductForView : Endpoint<ItemRequest>
    {
        private readonly GetProductForViewHandler _handler;

        public GetProductForView(GetProductForViewHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/Products/GetProductForView");
        }

        public override async Task HandleAsync(ItemRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null or an empty collection
            if (result == null )
            {
                await SendAsync(new { Message = "Product not found." }, statusCode: 404, cancellation: ct); // Returning 404 if no Products found
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
