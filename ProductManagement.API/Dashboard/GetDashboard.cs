using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.API.ProductEndpoint.Create;
using ProductManagement.Application.CommonDTO;
using Http = FastEndpoints.Http;

namespace ProductManagement.API.Dashboard
{
     [Authorize]
    public class GetDashboard : EndpointWithoutRequest
    {
        private readonly GetDashboardHandler _handler;

        public GetDashboard(GetDashboardHandler handler)
        {
            _handler = handler;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/api/dashboard");
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var result = await _handler.HandleAsync( ct);
           
            // Send success response
            await SendAsync(new
            {
                Message = "dashboard retrieved successfully.",
                Data = result
            }, statusCode: 200, cancellation: ct);
        }


    }

}
