using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikroGrupBireyselProje.Order.Application.Features.Orders.GetOrderHistory;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Order.API.Endpoints.Order;

public static class GetOrderHistoryEndpoint
{
    public static RouteGroupBuilder MapGetOrderHistoryEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/History",
                async ([FromServices] IMediator mediator) =>
                {
                    var result = await mediator.Send(new GetOrderHistoryQuery());
                    return result.ToActionResult();
                })
            .WithName("History")
            .Produces(StatusCodes.Status200OK)
            .MapToApiVersion(1.0);

        return group;
    }
}