using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using ProductManagement.Application.CommonDTO;
using ProductManagement.Application.ProductEndpoint.Update;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
    //[ApiExplorerSettings(GroupName = "Product")]
    [Authorize]
    public class DeleteProductEndpoint : Endpoint<ItemRequest>
    {
        private readonly DeleteProductHandler _handler;

        public DeleteProductEndpoint(DeleteProductHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.DELETE);
            Routes("/api/Products/DeleteProduct"); // No dynamic route parameter
        }

        public override async Task HandleAsync(ItemRequest req, CancellationToken ct)
        {
            // Call the handler to attempt the deletion
            bool result = await _handler.HandleAsync(req, ct);

            // If deletion failed (result is false), send a 400 response with failure message
            if (!result)
            {
                await SendAsync(new { Message = "Product deletion failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // If successful, send a 200 response with success message
            await SendAsync(new
            {
                Message = "Product deleted successfully",
                Data = new { ProductId = req.ItemId } // Sending the ID of the deleted Product as part of the response
            }, statusCode: 200, cancellation: ct);
        }
    }

}
