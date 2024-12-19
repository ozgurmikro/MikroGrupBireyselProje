﻿using MediatR;
using MikroGrupBireyselProje.Basket.Dto;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.GetBasket;

public static class GetAllBasketByUserIdEndpoint
{
    public static RouteGroupBuilder MapGetAllBasketByUserIdEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/",
                async (IMediator mediator) =>
                    (await mediator.Send(new GetAllBasketByUserIdQuery())).ToActionResult())
            .WithName("GetCategoryById")
            .Produces<List<BasketDto>>()
            .Produces(StatusCodes.Status404NotFound).MapToApiVersion(1.0);
        return group;
    }
}