using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.ProductEndpoint.Create;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.ProductEndpoint
{
    [ApiExplorerSettings(GroupName = "Product")]
    [Authorize]
    public class CreateProduct : Endpoint<CreateProductRequest>
    {
        private readonly CreateProductHandler _handler;

        public CreateProduct(CreateProductHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.POST);
            Routes("/api/Products");
         }

        public override async Task HandleAsync(CreateProductRequest req, CancellationToken ct)
        {
            var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null (indicating failure)
            if (result == null)
            {
                await SendAsync(new { Message = "Product creation failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // Send success response with status code 200
            await SendAsync(new
            {
                Message = "Product created successfully",
                Data = result // Assuming result is a ProductRecord or similar
            }, statusCode: 200, cancellation: ct);
        }

    }

}
