using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.DeleteBasket;

public record DeleteBasketCommand(Guid CourseId) : IRequestByServiceResult;