using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Order.Application.Features.Orders.GetOrderHistory;

public record GetOrderHistoryQuery : IRequestByServiceResult<List<GetOrderHistoryResponse>>;