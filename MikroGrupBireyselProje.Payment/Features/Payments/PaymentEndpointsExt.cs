using Asp.Versioning.Builder;
using MikroGrupBireyselProje.Payment.Features.Payments.GetAll;
using MikroGrupBireyselProje.Payment.Features.Payments.Receive;

namespace MikroGrupBireyselProje.Payment.Features.Payments;

public static class PaymentEndpointsExt
{
    public static void AddPaymentEndpointsExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/payments")
            .MapReceivePaymentEndpoint()
            .MapGetAllPaymentsEndpoint()
            .WithTags("Payments").WithApiVersionSet(apiVersionSet).RequireAuthorization();
    }
}