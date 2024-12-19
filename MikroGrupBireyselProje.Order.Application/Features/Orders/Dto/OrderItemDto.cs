namespace MikroGrupBireyselProje.Order.Application.Features.Orders.Dto;

public record OrderItemDto(
    Guid ProductId,
    string ProductName,
    decimal UnitPrice
);