using Refit;
using MikroGrupBireyselProje.Order.Application.Features.Orders.CreateOrder;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Order.Application.Contracts.refit;

public interface IPaymentService
{
    [Post("/api/v1/payments/receive")]
    Task<ApiResponse<ServiceResult<ReceivePaymentResponse>>> ReceivePaymentAsync(ReceivePaymentRequest request);
}