using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using ProductManagement.Application.CategoryEndpoint.Update;
using ProductManagement.Application.CommonDTO;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.CategoryEndpoint
{
    [Authorize]
    public class DeleteCategoryEndpoint : Endpoint<ItemRequest>
    {
        private readonly DeleteCategoryHandler _handler;

        public DeleteCategoryEndpoint(DeleteCategoryHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.DELETE);
            Routes("/api/categories/DeleteCategory");  // Dynamic route to pass CategoryId as a URL parameter
         }

        public override async Task HandleAsync(ItemRequest req, CancellationToken ct)
        {
            // Call the handler to attempt the deletion
            bool result = await _handler.HandleAsync(req, ct);

            // If deletion failed (result is false), send a 400 response with failure message
            if (!result)
            {
                await SendAsync(new { Message = "Category deletion failed." }, statusCode: 400, cancellation: ct);
                return;
            }

            // If successful, send a 200 response with success message
            await SendAsync(new
            {
                Message = "Category deleted successfully",
                Data = new { CategoryId = req.ItemId } // Sending the ID of the deleted category as part of the response
            }, statusCode: 200, cancellation: ct);
        }
    }

}
