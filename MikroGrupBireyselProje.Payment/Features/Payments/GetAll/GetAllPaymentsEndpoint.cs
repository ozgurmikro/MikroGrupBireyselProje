using MediatR;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Payment.Features.Payments.GetAll;

public static class GetAllPaymentsEndpoint
{
    public static RouteGroupBuilder MapGetAllPaymentsEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/",
                async (IMediator mediator) =>
                {
                    var result = await mediator.Send(new GetAllPaymentsQuery());

                    return result.ToActionResult();
                })
            .WithName("GetAllPayments")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .MapToApiVersion(1.0);

        return group;
    }
}