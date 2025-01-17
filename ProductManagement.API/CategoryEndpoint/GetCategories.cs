using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.CategoryEndpoint.Create;
using ProductManagement.Application.CategoryEndpoint.CommonDTO;
using ProductManagement.Common.DTO.Common;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.CategoryEndpoint
{
     [Authorize]
    public class GetCategories : Endpoint<GetCategoryRequest>
    {
        private readonly GetCategoryHandler _handler;

        public GetCategories(GetCategoryHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/categories/GetCategory");
         }

        public override async Task HandleAsync(GetCategoryRequest req, CancellationToken ct)
        {
           var result = await _handler.HandleAsync(req, ct);

            // Check if the result is null or an empty collection
            if (result == null || result.Count==0)
            {
                await SendAsync(new { Message = "No categories found." }, statusCode: 404, cancellation: ct); // Returning 404 if no categories found
                return;
            }

            // Send success response
            await SendAsync(new
            {
                Message = "Categories retrieved successfully.",
                Data = result
            }, statusCode: 200, cancellation: ct);
        }


    }

}
