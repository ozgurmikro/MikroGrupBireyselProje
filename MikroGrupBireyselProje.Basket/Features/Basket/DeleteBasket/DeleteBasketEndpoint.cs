﻿using MediatR;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.DeleteBasket;

public static class DeleteBasketEndpoint
{
    public static RouteGroupBuilder MapDeleteBasketEndpoint(this RouteGroupBuilder group)
    {
        group.MapDelete("/{courseId}",
                async (IMediator mediator, Guid courseId) =>
                {
                    var command = new DeleteBasketCommand(courseId);
                    var result = await mediator.Send(command);
                    return result.ToActionResult();
                })
            .WithName("DeleteBasket")
            .Produces(StatusCodes.Status204NoContent)
            .MapToApiVersion(1.0);

        return group;
    }
}