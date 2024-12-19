using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.AddBasket;

public record AddBasketCommand(
    Guid CourseId,
    string CourseName,
    string CoursePicture,
    decimal CoursePrice)
    : IRequestByServiceResult;