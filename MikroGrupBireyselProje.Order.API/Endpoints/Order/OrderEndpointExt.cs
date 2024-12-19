using Asp.Versioning.Builder;

namespace MikroGrupBireyselProje.Order.API.Endpoints.Order;

public static class OrderEndpointsExt
{
    public static void AddOrderEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/orders")
            .MapCreateOrderEndpoint()
            .MapGetOrderHistoryEndpoint()
            .WithTags("orders").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}