using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.ProductEndpoint.Update;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
    [ApiExplorerSettings(GroupName = "Product")]
    [Authorize]
    public class UpdateProduct : Endpoint<UpdateProductRequest>
    {
        private readonly UpdateProductHandler _handler;

        public UpdateProduct(UpdateProductHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.PUT);
            Routes("/api/Products/update");
         }

        public override async Task HandleAsync(UpdateProductRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null (indicating failure)
            if (result == null)
            {
                await SendAsync(new { Message = "Product update failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // Send success response with status code 200
            await SendAsync(new
            {
                Message = "Product updated successfully",
                Data = result // Assuming result is a ProductRecord or similar
            }, statusCode: 200, cancellation: ct);
        }

    }

}
