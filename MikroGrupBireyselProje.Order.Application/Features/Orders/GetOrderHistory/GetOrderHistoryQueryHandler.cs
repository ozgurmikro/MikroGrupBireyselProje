using AutoMapper;
using MediatR;
using MikroGrupBireyselProje.Order.Application.Contracts.Persistence;
using MikroGrupBireyselProje.Shared;
using MikroGrupBireyselProje.Shared.Services;

namespace MikroGrupBireyselProje.Order.Application.Features.Orders.GetOrderHistory;

public class GetOrderHistoryQueryHandler(
    IOrderRepository orderRepository,
    IIdentityService identityService,
    IMapper mapper)
    : IRequestHandler<GetOrderHistoryQuery, ServiceResult<List<GetOrderHistoryResponse>>>
{
    public async Task<ServiceResult<List<GetOrderHistoryResponse>>> Handle(GetOrderHistoryQuery request,
        CancellationToken cancellationToken)
    {
        var orders = await orderRepository.GetOrdersByUserIdAsync(identityService.GetUserId);

        return ServiceResult<List<GetOrderHistoryResponse>>.SuccessAsOk(
            mapper.Map<List<GetOrderHistoryResponse>>(orders));
    }
}