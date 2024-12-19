using MikroGrupBireyselProje.Order.Application.Features.Orders.Dto;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Order.Application.Features.Orders.CreateOrder;

public record CreateOrderCommand(
    float? DiscountRate,
    AddressDto Address,
    PaymentDto Payment,
    List<OrderItemDto> OrderItems)
    : IRequestByServiceResult;