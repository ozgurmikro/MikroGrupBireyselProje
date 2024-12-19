using MikroGrupBireyselProje.Basket.Dto;
using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.GetBasket;

public record GetAllBasketByUserIdQuery : IRequestByServiceResult<BasketDto>;