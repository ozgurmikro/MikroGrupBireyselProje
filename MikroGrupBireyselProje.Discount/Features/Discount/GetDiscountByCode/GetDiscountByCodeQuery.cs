using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Discount.Features.Discount.GetDiscountByCode;

public record GetDiscountByCodeQuery(string DiscountCode) : IRequestByServiceResult<GetDiscountByCodeQueryResponse>;