using MikroGrupBireyselProje.Shared;

namespace MikroGrupBireyselProje.Basket.Features.Basket.ApplyDiscountRate;

public record ApplyDiscountCouponCommand(string Coupon, float Rate) : IRequestByServiceResult;