using MikroGrupBireyselProje.Order.Application.Features.Orders.Dto;

namespace MikroGrupBireyselProje.Order.Application.Features.Orders.GetOrderHistory;

public record GetOrderHistoryResponse(DateTime OrderDate, decimal TotalPrice, List<OrderItemDto> OrderItems);