using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.ProductEndpoint.Delete;
using ProductManagement.Application.ProductEndpoint.Update;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
    [ApiExplorerSettings(GroupName = "Product")]
    [Authorize]
    public class DeleteProductEndpoint : Endpoint<DeleteProductRequest>
    {
        private readonly DeleteProductHandler _handler;

        public DeleteProductEndpoint(DeleteProductHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.DELETE);
            Routes("/api/Products/{ProductId}");  // Dynamic route to pass ProductId as a URL parameter
         }

        public override async Task HandleAsync(DeleteProductRequest req, CancellationToken ct)
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
                Data = new { ProductId = req.ProductId } // Sending the ID of the deleted Product as part of the response
            }, statusCode: 200, cancellation: ct);
        }
    }

}
