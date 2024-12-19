using AutoMapper;
using MikroGrupBireyselProje.Order.Application.Features.Orders.Dto;
using MikroGrupBireyselProje.Order.Application.Features.Orders.GetOrderHistory;
using MikroGrupBireyselProje.Order.Domain.Entities;

namespace MikroGrupBireyselProje.Order.Application.Features.Orders;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Domain.Entities.Order, OrderDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        CreateMap<Address, AddressDto>().ReverseMap();
        CreateMap<Domain.Entities.Order, GetOrderHistoryResponse>();
    }
}