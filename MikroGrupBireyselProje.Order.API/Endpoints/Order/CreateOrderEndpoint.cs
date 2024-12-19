using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikroGrupBireyselProje.Order.Application.Features.Orders.CreateOrder;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Order.API.Endpoints.Order;

public static class CreateOrderEndpoint
{
    public static RouteGroupBuilder MapCreateOrderEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
                async ([FromServices] IMediator mediator, [FromBody] CreateOrderCommand command) =>
                {
                    var result = await mediator.Send(command);

                    return result.ToActionResult();
                })
            .WithName("CreateOrder")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .MapToApiVersion(1.0)
            .AddEndpointFilter<ValidationFilter<CreateOrderCommand>>();

        return group;
    }
}