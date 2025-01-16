using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.CommonDTO;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
     [Authorize]
    public class GetCategoryForView : Endpoint<ItemRequest>
    {
        private readonly GetCategoryForViewHandler _handler;

        public GetCategoryForView(GetCategoryForViewHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/Category/GetCategoryForView");
        }

        public override async Task HandleAsync(ItemRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null or an empty collection
            if (result == null )
            {
                await SendAsync(new { Message = "Category not found." }, statusCode: 404, cancellation: ct); // Returning 404 if no Products found
                return;
            }

            // Send success response
            await SendAsync(new
            {
                Message = "Category retrieved successfully.",
                Data = result
            }, statusCode: 200, cancellation: ct);
        }


    }

}
